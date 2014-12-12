function [Image,Count] = CountPixel( img )
a=img;
D = -bwdist(~a);
L=watershed(D);
a(L==0)=0;
z=img;
Image=z-a;
Image=bwmorph(Image,'close');
Count=sum(sum(Image));
end

