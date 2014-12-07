function [newImg,pixelCount] = BorderObjects(img)
    %Invert to make the objects white:
    img = imcomplement(img);

    %Apply morphology:
    SE = strel('square',3);
    i = imdilate(img, SE);
    
    %Create border:
    newImg = i-img;
    
    %Count border pixels:
    pixelCount = sum(sum(newImg));
end