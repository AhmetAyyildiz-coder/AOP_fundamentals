/*
 *En temel düzeyde Castle dynamic proxy tanımı
 *
 * Runtime'da proxy tanımlaya yarayan bir teknolojidir.
 * Hafif proxy'ler oluşturmaya yarar. Nesnenin kodunu değiştirmeden üyelerine erişmemizi ve kontrolleri yapabilmemizi sağlar.
 * Bu sayede aop'yi kullanabilmemizi sağlar.
 *
 * Intercaptions'lar virtual'ların içerisine girebilir sadece.
 * Bu konu önemli. VİRTUAL mutlaka kullanılmalı.
 *
 * Bu projede en yalın hali ile bir aspect yapacağız.
 *
 */