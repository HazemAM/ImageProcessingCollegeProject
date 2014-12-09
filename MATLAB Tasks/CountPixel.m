function pixels = CountPixel( img )
img = imcomplement(img);
im=bwconncomp(img);
stats = regionprops(im,'Image','PixelList','EquivDiameter');

%Display the first component as an image
%imshow(stats(1).Image);
pixels=stats;
end

