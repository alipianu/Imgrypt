#Imgrypt


###What is Imgrypt?
Imgrypt is a steganography program that encrypts and decrypts messages in image pixel data. Developed with usability and ease-of-access in mind, Imgrypt allows you to discretely yet securely store and share sensitive information on your device. With Imgrypt, you can unsuspectingly hide passwords, personal information, essays, source code and much more – leaving behind an encrypted image virtually identical to the original.

Currently, Imgrypt is only compatible with Windows and supports two types of image (*.bmp* and *.png*) and message (*.txt* and *docx*) file formats.


###How does Imgrypt work?
When encrypting an image, Imgrypt takes a 3-word password and uses each word as a seed to generate 3 random sequences of numbers. The elements in the first sequence are used to define the distance between each secret pixel, the second sequence is used to randomly choose a message-terminating character, and the third sequence provides a formula for calculating the value of each secret pixel. After the Imgrypt algorithm generates and uses these sequences to modify your image of choice, it saves the encrypted image as a copy on disk at the location you specified.

When decrypting an image, Imgrypt takes the same 3-word password used to encrypt it and repeats the procedure detailed above in reverse. Once the message has been extracted from the image file, Imgrypt saves it to disk with your file type and location of choice.

By default, Imgrypt does not overwrite original image files with their encrypted versions. To enable this feature, you must navigate to the settings and change the file save name to the name of the original file, as well as specify the output location to be the same as that of the original.

**Disclaimer**: Please do not use Imgrypt as your primary method of storing sensitive information! Accessing the message contained in an encrypted image without the correct password is impossible – you will never get the information back if you forget the password!


###Advantages of Imgrypt
Imgrypt is a fantastic encryption tool with many advantages over other existing commercially available steganography programs. First and foremost, having the source code available online for anybody to see makes Imgrypt completely transparent with how it handles your confidential information. There are no usage policies or terms of service you must accept, just encrypt, decrypt, and enjoy. Imgrypt is also very easy and convenient to use. With ease-of-access settings, Imgrypt’s behaviour can be tweaked to meet your needs – reducing the time spent trying to locate and encrypt/decrypt images. Imgrypt supports MS Word (*.docx*) files and operates completely offline (excluding the help button).

Most importantly, images encrypted with Imgrypt are extremely secure. Pixel data is uncrackable without the correct password and passwords have up to a 1 in 10<sup>27</sup> chance of being cracked (see *Additional Notes*).


###Downloading and Installing Imgrypt
To install Imgrypt, navigate to the *Releases* tab, locate the latest release, and choose Source code (*.zip*). As of now, the latest release is *v1.0.0*. Once the zip file has been downloaded, extract it to any location on your computer and inside the folder navigate to Imgrypt **Installer** -> **Debug**, where you should find the Imgrypt Installer. After running and completing the installer, check to see that Imgrypt has been installed properly on your computer by **1)** ensuring that the installation location contains 4 files (*Imgrypt.exe*, *Imgrypt.exe.config*, *Imgrypt.ico*, *System.Net.Http.dll*) and **2)** Imgrypt is listed as a program on your computer in *Add or remove programs*. To run Imgrypt, you must run the *Imgrypt.exe* file in the installation location. For ease of access, you can create a shortcut of the executable and copy it to the desktop. After installation, the *.zip* folder and extracted folder can now be deleted.


###Uninstalling Imgrypt
To delete Imgrypt from your system simply navigate to *Add or remove programs*, choose Imgrypt and select *Uninstall*.


###Using Imgrypt to Encrypt
To encrypt an image, select *Encrypt*. After choosing an unencrypted image file, message file, and destination, click *Encrypt* once again. Finally, input your decryption password of choice and select *OK*.


###Using Imgrypt to Decrypt
To decrypt an image, select *Decrypt*. After choosing an encrypted image file and destination, click *Decrypt* once again. Finally, input the image’s decryption password select *OK*.


###Imgrypt Settings
Imgrypt provides many ease-of-access settings. To use them, select the gear icon at the top right corner of the start screen. In the *Default File Locations* tab, you can select default search locations when browsing for images or messages. Additionally, the *Encrypt/Decrypt Options* tabs allow you to select different image/message output file formats or names.


###Additional Notes
- There is a 1 in 10<sup>27</sup> chance cracking a decryption password only when it consists of 3 nine-character-long words (27 characters).
- It is extremely important that you choose a long password, favorably one where each word is a minimum of 5 characters long. Otherwise, your password can be easily brute forced, putting your encrypted information at risk.
- For Imgrypt to function properly, the number of characters in your message must not exceed the number of pixels in the image being encrypted.
- If Imgrypt outputs a file in a destination where a file with the same name and extension already exists, Imgrypt will overwrite the file. This applies to outputted images and messages.