function number = CountObjects(img)
    %Invert to make the objects white:
    img = imcomplement(img);
    [i,~]=CountPixel(img);
    a=img-i;
    %D = -bwdist(~a);
    %L=watershed(D);
    %a(L==0)=0;
    
    %Apply morphology erosion:
    %s=regionprops(img,'area');
    %SE = strel('disk',25);
    %i = imerode(img, SE);
    
    %Count using connected components:
    cc = bwconncomp(a);
    number = cc.NumObjects;
end