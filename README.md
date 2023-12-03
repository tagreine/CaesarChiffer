# Caesar Cipher Implementation

This project provides an implementation of Caesar Cipher, a type of substitution cipher in which each letter in the plaintext is 'shifted' a certain number of places down the alphabet.

## How to Use

Follow the instructions below to encrypt or decrypt sample text using this program:

1. **Navigate to the CaesarChiffer directory**

   Open your terminal and navigate to the project's folder with the following command:

   ```
   cd CaesarChiffer
   ```


2. **Encrypt sample text**

    You can encrypt the sample text using a shift of 7 places with the following command:

    ```
    dotnet run --text SampleText/text_plain.txt --shift 7 --encrypt
    ```
3. **Decrypt sample text**

    If you wish to decrypt the previously encrypted text, use the following command:

    ```
    dotnet run --text SampleText/text_plain_enc.txt --shift 7 --decrypt
    ```
    