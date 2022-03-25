# Biocryptography_electronic_health_records


This C# project was developed with Microsoft Visual Studio 2018.

This is an earlier version as I can not locate the final system but this  implementation demonstrates the concepts
of AES,SHA,fuzzy vault and fuzzy commitment schemes Fingerprint and Iris biometric in EHR 

Cryptographic keys were generated from image features. For detailed description see:
Omotosho, A., & Emuoyibofarhe, J. (2015). Private key management scheme using image features. Journal of Applied Security Research, 10(4), 543-557.


cryptographic keys were encoded using biometrics, escrow system is also included for key management layer between the patients and the health care provider. For detailed description, see:
Omotosho, A., Emuoyibofarhe, J., & Meinel, C. (2017). Ensuring patients' privacy in a cryptographic-based-electronic health records using bio-cryptography. International Journal of Electronic Healthcare, 9(4), 227-254.


# Requirements
Although the program can be recompiled for newer version of visual studio with minimal effort.

However this versiion uses:

#Software
MS Visual Studion 2018
MS SQL Server 2008
Matlab (anyversion should work) - this is because I created a .dll that imports Matlab functions into C#, this makes it easy to 
do single click feature extraction from images.

#Hardware
Secugen fingerprint biometric device (you can comment out the section of the code requiring this out)
CMIIRIS scanner BMT-20 (you can comment out the section of the code requiring this out)
