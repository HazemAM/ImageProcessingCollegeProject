function Discs = Disc( img )

all=CountObjects(img);
img = imcomplement(img);
SE = strel('square',55);
i = imerode(img, SE);
cc = bwconncomp(i);
Discs = all-cc.NumObjects;

end

