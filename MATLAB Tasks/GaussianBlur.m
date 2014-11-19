function blurred = GaussianBlur(image, sigma)
%Performing a Gaussian blur filter on an image.
    
    %% Gaussian (1D)
    maskSize     = 2*int32(3.7*sigma-0.5)+1;
    gaussianMask = fspecial('gaussian', [1 double(maskSize)], sigma);
    halfBlurred  = imfilter(image, gaussianMask);
    blurred      = imfilter(halfBlurred, gaussianMask');
end