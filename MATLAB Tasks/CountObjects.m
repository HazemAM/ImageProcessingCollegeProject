function number = CountObjects(img)
    %Invert to make the objects white:
    img = imcomplement(img);

    %Apply morphology erosion:
    SE = strel('disk',25);
    i = imerode(img, SE);
    
    %Count using connected components:
    cc = bwconncomp(i);
    number = cc.NumObjects;
end