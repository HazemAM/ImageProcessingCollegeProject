function [BlueMMs, Count] = MATLABTask2(img)
cform = makecform('srgb2lab');
lab_img = applycform(img,cform);
ab = double(lab_img(:,:,2:3));
nrows = size(ab,1);
ncols = size(ab,2);
ab = reshape(ab,nrows*ncols,2);

nColors = 7;
[idx, c] = kmeans(ab,nColors,'distance','sqEuclidean','Replicates',1);
segmented_images = cell(1,nColors);
pixel_labels = reshape(idx,nrows,ncols);
rgb_label = repmat(pixel_labels,[1 1 3]);

for k = 1:nColors
    color = img;
    color(rgb_label ~= k) = 0;
    segmented_images{k} = color;
end
mean_cluster_value = mean(c,2);
[~, idx] = sort(mean_cluster_value);
blue_cluster_num = idx(1);

L = lab_img(:,:,1);
blue_idx = find(pixel_labels == blue_cluster_num);
L_blue = L(blue_idx);
is_light_blue = im2bw(L_blue,graythresh(L_blue));
mmsLabels = repmat(uint8(0),[nrows ncols]);
mmsLabels(blue_idx(is_light_blue==false)) = 1;
mmsLabels = repmat(mmsLabels,[1 1 3]);
BlueMMs = img;
BlueMMs(mmsLabels ~= 1) = 0;
bwBluemms=im2bw(BlueMMs,graythresh(BlueMMs));
se=strel('disk',10);
bwemorphed=imdilate(bwBluemms,se);
se=strel('disk',23);
bwemorphed=imerode(bwemorphed,se);
bmcc=bwconncomp(bwemorphed);
Count=bmcc.NumObjects;
end

