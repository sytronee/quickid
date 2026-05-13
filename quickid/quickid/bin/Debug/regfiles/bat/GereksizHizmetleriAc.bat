@echo off

echo Akıllı Kart Hizmeti başlatılıyor...
sc config ScDeviceEnum start= demand
sc start ScDeviceEnum

echo Akıllı Kart Cihaz Numaralandırması Hizmeti başlatılıyor...
sc config CertPropSvc start= demand
sc start CertPropSvc

echo Akıllı Kart Kaldırma İlkesi başlatılıyor...
sc config SCPolicySvc start= demand
sc start SCPolicySvc

echo AllJoyn Yönlendirici Hizmeti başlatılıyor...
sc config AJRouter start= demand
sc start AJRouter

echo Bağlı Kullanıcı Deneyimleri ve Telemetrisi başlatılıyor...
sc config DiagTrack start= demand
sc start DiagTrack

echo BranchCache başlatılıyor...
sc config PeerDistSvc start= demand
sc start PeerDistSvc

echo Coğrafi Konum Hizmeti başlatılıyor...
sc config lfsvc start= demand
sc start lfsvc

echo Cüzdan Hizmeti başlatılıyor...
sc config WalletService start= demand
sc start WalletService

echo Dağıtılmış Bağlantı İzleme İstemcisi başlatılıyor...
sc config NcaSvc start= demand
sc start NcaSvc

echo Diagnostic Execution Service başlatılıyor...
sc config diagnosticshub.standardcollector.service start= demand
sc start diagnosticshub.standardcollector.service

echo Dokunmatik Klavyeyi ve El Yazısı Paneli Hizmeti başlatılıyor...
sc config TabletInputService start= demand
sc start TabletInputService

echo Internet Bağlantısı Paylaşımı (ICS) başlatılıyor...
sc config SharedAccess start= demand
sc start SharedAccess

echo IP Yardımcısı başlatılıyor...
sc config iphlpsvc start= demand
sc start iphlpsvc

echo Microsoft ® Diagnostics Hub'ı Standart Toplayıcı Hizmeti başlatılıyor...
sc config DiagTrack start= demand
sc start DiagTrack

echo Perakende Gösteri Hizmeti başlatılıyor...
sc config RetailDemo start= demand
sc start RetailDemo

echo TCP/IP NetBIOS Yardımcısı başlatılıyor...
sc config lmhosts start= demand
sc start lmhosts

echo Telefon başlatılıyor...
sc config PhoneSvc start= demand
sc start PhoneSvc

echo Telefon Hizmeti başlatılıyor...
sc config TapiSrv start= demand
sc start TapiSrv

echo Uzak Kayıt Defteri başlatılıyor...
sc config RemoteRegistry start= demand
sc start RemoteRegistry

echo Uzak Masaüstü Hizmetleri başlatılıyor...
sc config TermService start= demand
sc start TermService

echo Uzak Masaüstü hizmetleri kullanıcı modu Bağlantı Noktası Yeniden Yönlendiricisi başlatılıyor...
sc config UmRdpService start= demand
sc start UmRdpService

echo Uzak masaüstü yapılandırması başlatılıyor...
sc config SessionEnv start= demand
sc start SessionEnv

echo Uzamsal Veri Hizmeti başlatılıyor...
sc config MapsBroker start= demand
sc start MapsBroker

echo Windows Algılama Benzetimi Hizmeti başlatılıyor...
sc config Sense start= demand
sc start Sense

echo Windows Algılama Hizmeti başlatılıyor...
sc config SensrSvc start= demand
sc start SensrSvc

echo Windows Hata raporlama hizmeti başlatılıyor...
sc config WerSvc start= demand
sc start WerSvc

echo Windows Insider hizmeti başlatılıyor...
sc config wisvc start= demand
sc start wisvc

echo Windows Kamera Çerçeve Sunucusu başlatılıyor...
sc config FrameServer start= demand
sc start FrameServer

echo Windows Kamera Çerçeve Sunucusu İzleyicisi başlatılıyor...
sc config FrameServerWatcher start= demand
sc start FrameServerWatcher

echo Windows Mixed Reality OpenXR Service başlatılıyor...
sc config OpenXRService start= demand
sc start OpenXRService

echo Windows Mobil Etkin Nokta Hizmeti başlatılıyor...
sc config icssvc start= demand
sc start icssvc

echo Windows Yedekleme başlatılıyor...
sc config SDRSVC start= demand
sc start SDRSVC

echo Yazdırma Birikticisi başlatılıyor...
sc config Spooler start= demand
sc start Spooler

echo Çevrimdışı Dosyalar başlatılıyor...
sc config CscService start= demand
sc start CscService

echo Ödeme ve NFC/SE Yöneticisi başlatılıyor...
sc config WalletService start= demand
sc start WalletService

echo İkincil oturum açma başlatılıyor...
sc config seclogon start= demand
sc start seclogon

echo İndirilen Haritalar yöneticisi başlatılıyor...
sc config MapsBroker start= demand
sc start MapsBroker

echo Hizmetler başlatıldı.
exit
