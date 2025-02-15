Описание

Этот проект представляет собой программу для шифрования и дешифрования данных с использованием алгоритма, основанного на повторении ключа и сдвиге символов в заданном алфавите. Он предоставляет возможность вводить ключ и фразу, после чего шифровать и расшифровывать сообщение, используя алгоритм, который сочетает в себе концепции простого шифра Цезаря и повторяющегося ключа.
Возможности

    Шифрование: Программа шифрует введенную фразу, используя заданный ключ. Алгоритм сдвигает символы в фразе в зависимости от их положения в алфавите.
    Дешифровка: Программа может расшифровать зашифрованное сообщение, используя тот же ключ.

Как использовать

    Введите ключ для шифрования и дешифровки.
    Введите фразу, которую хотите зашифровать.
    Программа выведет зашифрованное сообщение.
    Программа также расшифрует зашифрованную фразу обратно в исходный текст.

Пример использования

Type the key: МойКлюч
Type the phrase: ПриветМир
Encrypted: ШЯГЙГЮУ
Decrypted: ПРИВЕТМИР

Как работает

    Ключ повторяется до длины фразы.
    Для каждого символа фразы вычисляется сдвиг, который определяется позицией символа в алфавите и позицией символа из ключа.
    Для шифрования и дешифровки используется один и тот же алгоритм, только с разными операциями: при шифровании сдвиг складывается, а при дешифровке вычитается.

Технические детали

    Алфавит включает в себя все русские буквы (как заглавные, так и строчные), а также несколько знаков препинания и специальные символы.
    Программа написана на языке C#.
    В качестве алгоритма используется модификация шифра Цезаря, где сдвиг зависит от символов ключа.


Description

This project is a program for encrypting and decrypting data using an algorithm based on key repetition and character shifting in a specified alphabet. It allows the user to input a key and a phrase, then encrypt and decrypt the message using an algorithm that combines concepts of a simple Caesar cipher and repeated key.
Features

    Encryption: The program encrypts the entered phrase using the provided key. The algorithm shifts the characters of the phrase based on their position in the alphabet.
    Decryption: The program can decrypt an encrypted message using the same key.

How to Use

    Enter a key for encryption and decryption.
    Enter the phrase you want to encrypt.
    The program will output the encrypted message.
    The program will also decrypt the encrypted phrase back to the original text.

Example Usage

Type the key: МойКлюч
Type the phrase: ПриветМир
Encrypted: ШЯГЙГЮУ
Decrypted: ПРИВЕТМИР

How It Works

    The key is repeated until it matches the length of the phrase.
    For each character in the phrase, the shift is calculated based on the character's position in the alphabet and the position of the character in the key.
    The same algorithm is used for encryption and decryption, except that the shift is added for encryption and subtracted for decryption.

Technical Details

    The alphabet includes all Russian letters (both uppercase and lowercase), along with some punctuation marks and special characters.
    The program is written in C#.
    The algorithm is a variation of the Caesar cipher, where the shift is determined by the characters of the key.
