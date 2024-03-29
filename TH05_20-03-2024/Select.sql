Select Loai.TenLoai, count(*) as SL
from SanPham,Loai
where Loai.MaLoai = SanPham.MaLoai
group by TenLoai