function pixels = CountPixel( img )
img = imcomplement(img);
CH_objects = bwconvhull(img,'objects');
imshow(CH_objects);
im=bwconncomp(img);
meh=CH_objects-img;
imshow(meh);
stats = regionprops(im,'Image','PixelList');

%Display the first component as an image
%imshow(stats(1).Image);
pixels=stats;
end

