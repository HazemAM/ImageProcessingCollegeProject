function New = LocalStatistics(Old, winSize, E, K0, K1, K2)
[H, W, L] = size(Old);
HalfWinSize = floor(winSize/2);
Mg=mean(Old(:,:,:));
Dg=std(double(Old(:,:,:)));
New=Old;
%Process the image in CONVOLUTION manner
for i=1:L
    %seperate each color channel (R, G, B) in TmpBuf and process it
    TmpBuf = Old(:,:,i);
    %Convolution loops
    for y= HalfWinSize + 1 : H - HalfWinSize 
        for x= HalfWinSize + 1 : W - HalfWinSize 
            LocalWin = TmpBuf(y - HalfWinSize : y + HalfWinSize , x - HalfWinSize : x + HalfWinSize );
            Vector = double(reshape(LocalWin, 1, winSize * winSize));
            Ml = mean(Vector);
            Sl = std(Vector);
            if (Ml <= K0 * Mg(i)) &&  (K1 * Dg(i) <= Sl <= K2 * Dg(i))
            New(y,x,i)= E * Old(y,x,i);
            else
                New(y,x,i)=Old(y,x,i);
            end
        end
    end    
end
end