# Kata - Anagrams - Grupo 1

## Requerimientos

- 01: Dado un archivo que contiene una palabra por linea, el programa debe imprimir todas las combinaciones posibles de palabras que son anagramas.
- 02: El usuario debe pasar como parametro la palabra que desea buscar en un archivo para verificar si existe un anagrama en este o no.

## Criterios de aceptacion

- 01: El archivo no puede estar vacio.
- 02: El archivo de lectura debe tener una palabra por línea.
- 03: Las palabras de entrada no deben tener carácteres especiales.
- 04: El programa debe imprimir en cada línea el conjunto de anagramas de la palabra buscada.
- 05: El programa será Case-sensitive.
- 06: Comprobar que dos palabras sean anagramas.
- 07: Comprobar que una palabra tenga anagramas en un archivo.

## Escenarios de pruebas

- Caso de prueba #1 Probar que una palabra sea un anagrama.
  1.1 IsAnagram("amor", "mora") --> True
  1.2 IsAnagram("giro", "ori") --> False
  1.3 IsAnagram("giro", "orr") --> False

- Caso de prueba #2 Probar si un archivo se encuentra anagramas de un string:
  2.1 -- findAnSpecificAnagramInFile(path, "paro") --> True
  2.2 -- findAnSpecificAnagramInFile(path, "lolo") --> False

- Case de prueba #3 Buscar todos los anagramas de un archivo:
  3.1 -- findAllAnagramsInFile(Input.txt, Output.txt) -- 2
  3.2 -- findAllAnagramsInFile(Text.txt, Output.txt) -- 20,683
