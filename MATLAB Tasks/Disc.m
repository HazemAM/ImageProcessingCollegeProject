function Discs = Disc( img )
image=img;
img = imcomplement(img);
size=Sizes(img);
[size, type]=max(size);
if type==1
    SE = strel('square',floor(size-5));
    all=CountObjects(image);
    i = imerode(img, SE);
    cc = bwconncomp(i);
    Discs = all-cc.NumObjects;
else
    SE = strel('disk',floor(size-5));
    i = imerode(img, SE);
    cc = bwconncomp(i);
    Discs = cc.NumObjects;
end    


end

