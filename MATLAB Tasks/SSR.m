function retImage = SSR(image, sigma)
%SSR Single Scale Retinex
    
    %% Gaussian (1D)
    blurred = GaussianBlur(image, sigma);
    
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
    retImage = uint8(retImage*255); %TO BYTE
end