function retImage = SSR(image, sigma)
%SSR Single Scale Retinex
    
    %% Gaussian
    N = int32((3.7 * sigma) - 0.5);
    maskSize = double((2 * N) + 1);
    
    GaussianMask = fspecial('gaussian', maskSize, sigma);
    blurred = imfilter(image, GaussianMask);
    
    %% Retinex
    image = double(image)+0.1;
    blurred = double(blurred)+0.1;
    retImage = log10(image ./ blurred);
    
    %% Normalization
    uint8(255*mat2gray(retImage));
    
    %%%OLD WAY%%%
    %oldMin = min(min(retImage));
    %oldMax = max(max(retImage));
    %for i=1:3;
    %    retImage(:,:,i) = double( (retImage(:,:,i)-oldMin(1,1,i)) ./ (oldMax(1,1,i)-oldMin(1,1,i)) );
    %    %retImage(:,:,i) = imadjust(retImage(:,:,i));
    %end
    %%%%%%%%%%%%%
    
    %% Back to [0,255]
    retImage = uint8(retImage*255); %WITH CONVERT TO INT (MATLAB)
end