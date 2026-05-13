@echo off

echo Akıllı Kart Hizmeti devre dışı bırakılıyor...
sc stop ScDeviceEnum
sc config ScDeviceEnum start= disabled

echo Akıllı Kart Cihaz Numaralandırması Hizmeti devre dışı bırakılıyor...
sc stop CertPropSvc
sc config CertPropSvc start= disabled

echo Akıllı Kart Kaldırma İlkesi devre dışı bırakılıyor...
sc stop SCPolicySvc
sc config SCPolicySvc start= disabled

echo AllJoyn Yönlendirici Hizmeti devre dışı bırakılıyor...
sc stop AJRouter
sc config AJRouter start= disabled

echo Bağlı Kullanıcı Deneyimleri ve Telemetrisi devre dışı bırakılıyor...
sc stop DiagTrack
sc config DiagTrack start= disabled

echo BranchCache devre dışı bırakılıyor...
sc stop PeerDistSvc
sc config PeerDistSvc start= disabled

echo Coğrafi Konum Hizmeti devre dışı bırakılıyor...
sc stop lfsvc
sc config lfsvc start= disabled

echo Cüzdan Hizmeti devre dışı bırakılıyor...
sc stop WalletService
sc config WalletService start= disabled

echo Dağıtılmış Bağlantı İzleme İstemcisi devre dışı bırakılıyor...
sc stop NcaSvc
sc config NcaSvc start= disabled

echo Diagnostic Execution Service devre dışı bırakılıyor...
sc stop diagnosticshub.standardcollector.service
sc config diagnosticshub.standardcollector.service start= disabled

echo Dokunmatik Klavyeyi ve El Yazısı Paneli Hizmeti devre dışı bırakılıyor...
sc stop TabletInputService
sc config TabletInputService start= disabled

echo Internet Bağlantısı Paylaşımı (ICS) devre dışı bırakılıyor...
sc stop SharedAccess
sc config SharedAccess start= disabled

echo IP Yardımcısı devre dışı bırakılıyor...
sc stop iphlpsvc
sc config iphlpsvc start= disabled

echo Microsoft ® Diagnostics Hub'ı Standart Toplayıcı Hizmeti devre dışı bırakılıyor...
sc stop DiagTrack
sc config DiagTrack start= disabled

echo Perakende Gösteri Hizmeti devre dışı bırakılıyor...
sc stop RetailDemo
sc config RetailDemo start= disabled

echo TCP/IP NetBIOS Yardımcısı devre dışı bırakılıyor...
sc stop lmhosts
sc config lmhosts start= disabled

echo Telefon devre dışı bırakılıyor...
sc stop PhoneSvc
sc config PhoneSvc start= disabled

echo Telefon Hizmeti devre dışı bırakılıyor...
sc stop TapiSrv
sc config TapiSrv start= disabled

echo Uzak Kayıt Defteri devre dışı bırakılıyor...
sc stop RemoteRegistry
sc config RemoteRegistry start= disabled

echo Uzak Masaüstü Hizmetleri devre dışı bırakılıyor...
sc stop TermService
sc config TermService start= disabled

echo Uzak Masaüstü hizmetleri kullanıcı modu Bağlantı Noktası Yeniden Yönlendiricisi devre dışı bırakılıyor...
sc stop UmRdpService
sc config UmRdpService start= disabled

echo Uzak masaüstü yapılandırması devre dışı bırakılıyor...
sc stop SessionEnv
sc config SessionEnv start= disabled

echo Uzamsal Veri Hizmeti devre dışı bırakılıyor...
sc stop MapsBroker
sc config MapsBroker start= disabled

echo Windows Algılama Benzetimi Hizmeti devre dışı bırakılıyor...
sc stop Sense
sc config Sense start= disabled

echo Windows Algılama Hizmeti devre dışı bırakılıyor...
sc stop SensrSvc
sc config SensrSvc start= disabled

echo Windows Hata raporlama hizmeti devre dışı bırakılıyor...
sc stop WerSvc
sc config WerSvc start= disabled

echo Windows Insider hizmeti devre dışı bırakılıyor...
sc stop wisvc
sc config wisvc start= disabled

echo Windows Kamera Çerçeve Sunucusu devre dışı bırakılıyor...
sc stop FrameServer
sc config FrameServer start= disabled

echo Windows Kamera Çerçeve Sunucusu İzleyicisi devre dışı bırakılıyor...
sc stop FrameServerWatcher
sc config FrameServerWatcher start= disabled

echo Windows Mixed Reality OpenXR Service devre dışı bırakılıyor...
sc stop OpenXRService
sc config OpenXRService start= disabled

echo Windows Mobil Etkin Nokta Hizmeti devre dışı bırakılıyor...
sc stop icssvc
sc config icssvc start= disabled

echo Windows Yedekleme devre dışı bırakılıyor...
sc stop SDRSVC
sc config SDRSVC start= disabled

echo Yazdırma Birikticisi devre dışı bırakılıyor...
sc stop Spooler
sc config Spooler start= disabled

echo Çevrimdışı Dosyalar devre dışı bırakılıyor...
sc stop CscService
sc config CscService start= disabled

echo Ödeme ve NFC/SE Yöneticisi devre dışı bırakılıyor...
sc stop WalletService
sc config WalletService start= disabled

echo İkincil oturum açma devre dışı bırakılıyor...
sc stop seclogon
sc config seclogon start= disabled

echo İndirilen Haritalar yöneticisi devre dışı bırakılıyor...
sc stop MapsBroker
sc config MapsBroker start= disabled

echo Hizmetler devre dışı bırakıldı.
exit
