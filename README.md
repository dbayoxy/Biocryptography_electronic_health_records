# Biocryptography_electronic_health_records


This C# project was developed with Microsoft Visual Studio 2018.

This is an earlier version (this repo is dirty) as I can not locate the final system but this  implementation demonstrates the concepts
of AES, SHA256, fuzzy vault and fuzzy commitment schemes Fingerprint and Iris biometric in EHR.

Cryptographic keys were generated from image features. For a detailed description see:
Omotosho, A., & Emuoyibofarhe, J. (2015). Private key management scheme using image features. Journal of Applied Security Research, 10(4), 543-557.


cryptographic keys were encoded using biometrics, escrow system is also included for the key management layer between the patients and the health care provider. For a detailed description, see:
Omotosho, A., Emuoyibofarhe, J., & Meinel, C. (2017). Ensuring patients' privacy in cryptographic-based electronic health records using bio-cryptography. International Journal of Electronic Healthcare, 9(4), 227-254.


# Requirements
Although the program can be recompiled for a newer version of MS Visual Studio with minimal effort.

However, this version uses:

# Software
1. MS Visual Studio 2018
2. MS SQL Server 2008
3. Matlab 2013(any version should work) - this is because I created a .dll that imports Matlab functions into C#, this makes it easy to 
do single-click feature extraction from images.

# Languages
1. C#
2. Matlab
3. SQL

# Hardware
1. Secugen fingerprint biometric device (you can comment out the section of the code requiring this out)

2. CMIIRIS scanner BMT-20 (you can comment out the section of the code requiring this out)
