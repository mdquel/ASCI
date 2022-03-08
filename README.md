# ASCI. Análisis de sentimiento conversacional inteligente
## Consideraciones generales

Esta solución tiene como objetivo utilizar el análisis de opinión de una conversación para obtener una valoración positiva o negativa durante transcurso de la misma.

Módulos que componen la solución:
* **DataSetProcess**: Este proyecto es el encargado de preparar los datos para poder evaluar el sentimiento. Incluye el generador de modelos ML.NET, para poder reentrenar el modelo.
* **SentimentWebApi**: Contempla el conjunto de servicios que se exponen para ofrecer el análisis de sentimiento.
* **SentimentChat**: Interfaz que se le presenta al usuario para poder interactuar con la aplicación.
* **TestSentimentWebApi**: Proyecto de test para validación de los servicios. 

## Herramientas

* [Microsoft Visual Studio](https://visualstudio.microsoft.com)
* [ML.NET](https://dotnet.microsoft.com/en-us/apps/machinelearning-ai/ml-dotnet)
* [Web Speech API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Speech_API)

## Recursos
* [Galería de iconos](https://emojipedia.org)

## Sistemas operativos y arquitectura de procesadores soportados por ML.NET

Windows, Linux, y macOS usando .NET Core, o Windows usando .NET Framework.

ML.NET también se ejecuta en ARM64, Apple M1 y Blazor Web Assembly. Sin embargo, existen algunas [limitaciones](docs/project-docs/platform-limitations.md).

Es compatible con todas las plataformas 64 bits.   
Es compatible con Windows 32 bits, excepto para la funcionalidad relacionada con TensorFlow y LightGBM.   

## ML.NET paquetes NuGet

[![NuGet Status](https://img.shields.io/nuget/vpre/Microsoft.ML.svg?style=flat)](https://www.nuget.org/packages/Microsoft.ML/)

## Prerrequisitos

[SDK de .NET Core 3.1 o posterior](https://dotnet.microsoft.com/download)   
[ML.NET CLI](https://docs.microsoft.com/en-us/dotnet/machine-learning/tutorials/sentiment-analysis-cli#:~:text=Visual%20Studio%202019-,ML.NET%20CLI,-You%20can%20either)
 
### Instalación

* Clonado del repositorio
   ```sh
   git clone https://github.com/mdquel/ASCI.git
   ```

## Licencia
Distribuido bajo [GPL v3 License](https://www.gnu.org/licenses/gpl-3.0.html). `LICENSE` para más información.

## Contacto
Github link: [https://github.com/mdquel](https://github.com/mdquel)
