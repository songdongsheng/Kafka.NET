Simple Kafka client library for .NET
====================================

Questions & Comments
--------------------

Any feedback is welcome, please use the Issues on this repository.

Build Status
------------

|CoreCLR 1.0 |.NET Framework 4.6 |.NET Framework 4.5 |
|:---------: |:-----------------:|:-----------------:|
| ![](https://ci.appveyor.com/api/projects/status/github/songdongsheng/Kafka.NET?branch=master&svg=true) | ![](https://ci.appveyor.com/api/projects/status/github/songdongsheng/Kafka.NET?branch=master&svg=true) | ![](https://ci.appveyor.com/api/projects/status/github/songdongsheng/Kafka.NET?branch=master&svg=true) |

Basic usage
-----------

    Producer producer = new Producer(
        new List<Uri> {
            new Uri("kafka://192.168.0.123:9092/"),
            new Uri("kafka://192.168.0.124:9092/"),
            new Uri("kafka://192.168.0.125:9092/"),
            });

    producer.Send(
        new List<StringMessage> {
            new StringMessage("key1", "msg1"),
            new StringMessage("key2", "msg2"),
            new StringMessage("key3", "msg3")
            });

    producer.Send(
            new StringMessage("key1", "msg1"),
            myCallback);

Building from source
--------------------

    cd Kafka.NET

    msbuild Kafka.NET.csproj /t:Rebuild /p:Platform=AnyCPU /p:Configuration=Release
    msbuild Kafka.NET.csproj /t:Rebuild /p:Platform=AnyCPU /p:Configuration=Release46
    msbuild Kafka.NET.csproj /t:Rebuild /p:Platform=AnyCPU /p:Configuration=Release45

    dotnet restore
    dotnet build -c Release

    doxygen

    nuget pack Kafka.NET.nuspec
