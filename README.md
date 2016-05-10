# TLSWizard
Dotnet/Mono Tool for creating TLS(HTTPS) Root and server certificates using OpenSSL 

Dependencies:

Nuget Newtonsoft.Json by:
Install-Package Newtonsoft.Json
(https://www.nuget.org/packages/newtonsoft.json/)



https://github.com/marcominetti/openssl-net (using this one slightly modified, the original is exactly for version 1.0.1g of libcrypto.so/libeay32.dll and libssl.so/ssleay32.dll)
or:
https://github.com/openssl-net/openssl-net (for version 1.0.2a of libeay32.dll and ssleay32.dll)

OpenSSL for Windows:
http://slproweb.com/download/Win32OpenSSL_Light-1_0_2h.exe
http://slproweb.com/download/Win32OpenSSL-1_0_2h.exe
http://slproweb.com/download/Win32OpenSSL_Light-1_0_1t.exe
http://slproweb.com/download/Win32OpenSSL-1_0_1t.exe

for Linux/Mac: use your package manager to install openssl.