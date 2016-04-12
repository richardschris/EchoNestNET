# EchoNestNET
Echo Nest library for .NET

## SPOTIFY HAS DISCONTINUED ECHONEST SO I'M DISCONTINUING WORK ON THIS

To use it for the limited time Echo Nest exists, you can use a pretty ad hoc interface.

```
using EchoNestNET;

Connect c = new Connect("API KEY");
Parser p = new Parser();
Parameters params = new Parameters();

string query = c.SongSearch("courtney barnett", params);
IList<Song> songList = parser.SongParse(query);
```

The library's query methods and object model are almost exact representations of the Echo Nest data, so query methods correspond closely to Echo Nest API paths and returns objects of the type that Echo Nest returns. Consult the code or Echo Nest documentation for more info.

RIP Echo Nest
