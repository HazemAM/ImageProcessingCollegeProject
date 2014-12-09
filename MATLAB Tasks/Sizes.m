function [ Disk,Square ] = Sizes( img )

im=bwconncomp(img);
stats = regionprops(im,'EquivDiameter');
Disk=stats(3).EquivDiameter;
Square=stats(4).EquivDiameter;
end

