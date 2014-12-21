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
meh=img;
meh(mmsLabels > 0.9) = 0;
meh(:,:,1)=0;
meh(:,:,2)=0;
meh(meh<180)=0;
BlueMMs(mmsLabels <= 0.9) = 0;
BlueMMs=BlueMMs+meh;
beh=BlueMMs(:,:,3);
bwBluemms=im2bw(beh);
se=strel('disk',5);
bwemorphed=imfill(bwBluemms,'holes');
bwemorphed=imerode(bwemorphed,se);
bwemorphed=imclose(bwemorphed,se);
BlueMMs=img;
for j=1:ncols
    for i=1:nrows
        if(bwemorphed(i,j)==1)
            BlueMMs(i,j,1)=img(i,j,1);
            BlueMMs(i,j,2)=img(i,j,2);
            BlueMMs(i,j,3)=img(i,j,3);
        else
            BlueMMs(i,j,1)=0;
            BlueMMs(i,j,2)=0;
            BlueMMs(i,j,3)=0;
        end
    end
end
bmcc=bwconncomp(bwemorphed);
Count=bmcc.NumObjects;
x=5;
end

