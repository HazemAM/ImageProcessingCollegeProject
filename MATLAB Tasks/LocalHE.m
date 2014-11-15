function New = LocalHE(Old, WinSize)
New=Old;
[H, W, L] = size(Old);
HalfWinSize = floor(WinSize/2);
for i=1:L
    %seperate each color channel (R, G, B) in TmpBuf and process it
    TmpBuf = Old(:,:,i);
    %Convolution loops
    for y= HalfWinSize + 1 : H - HalfWinSize
        for x= HalfWinSize + 1 : W - HalfWinSize
            cdf=zeros(256,1);
            LocalWin = TmpBuf(y - HalfWinSize : y + HalfWinSize , x - HalfWinSize : x + HalfWinSize );
            Vector = double(reshape(LocalWin, 1, WinSize * WinSize));
            for l=1:size(Vector,2)
                p=Vector(1,l);
                cdf(p+1)=cdf(p+1)+1;
            end
            for l=2:256
                cdf(l)=cdf(l)+cdf(l-1);
            end
            New(y,x,i)=round(cdf(TmpBuf(y,x,i)+1)/(WinSize*WinSize)*255);
        end
    end
end
end

