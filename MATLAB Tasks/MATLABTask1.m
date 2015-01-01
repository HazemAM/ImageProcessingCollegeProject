function [NewImg, Count] = MATLABTask1(img, Num)
%MATLABTASK1 Summary of this function goes here
    if(Num == 1)
        [NewImg, Count] = BorderObjects(img);
    elseif(Num == 2)
        Count = CountObjects(img);
        NewImg = zeros(1);
    elseif(Num == 3)
        Count = Disc(img);
        NewImg = zeros(1);
    elseif(Num == 4)
        [NewImg,Count] = CountPixel(~img);
    else
        error('Wrong operation number.');
    end
end
