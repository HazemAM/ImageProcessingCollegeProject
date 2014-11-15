function retImage = SSR(image, sigma)
%SSR Single Scale Retinex

    N = int32((3.7 * sigma) - 0.5);
    maskSize = double((2 * N) + 1);
    
    % Gaussian
    GaussianMask = fspecial('gaussian', maskSize, sigma);
    blurred = imfilter(image, GaussianMask);
    
    % Retinex
    image = double(image)+0.1;
    blurred = double(blurred)+0.1;
    retImage = log10(image ./ blurred);
    
    % Retinex, trying the classic way
    %[x,y] = size(blurred);
    %retImage = zeros(x,y);
    %for i=1:x;
    %    for j=1:y;
    %        retImage(i,j) = log( (image(i,j)+0.01)/(blurred(i,j)+0.01) );
    %    end
    %end
end