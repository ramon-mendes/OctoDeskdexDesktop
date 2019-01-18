# OctoDeskdex

The Octodex desktop version.

Yes, that's it, a Pokedex of Octocats!

![OctoDeskdex](https://github.com/ramon-mendes/OctoDeskdex_Desktop/raw/master/octodeskdex.gif)


## Download for

- [Windows](https://www.dropbox.com/s/tz7roypz9ul6ghe/OctoDeskdexWin.zip?raw=1)
- [OSX](https://www.dropbox.com/s/96gnkldoynprspg/OctoDeskdexOSX.zip?raw=1)
- Linux: not yet available

## Requirements to build it

**Windows:**

- Visual Studio
- &gt;= .NET 4.5

**Linux:**

- MonoDevelop
- 64bit distro
- [Mono installation](http://www.mono-project.com/docs/getting-started/install/linux/)
- Install Sciter lib through the *install-libsciter.sh* script inside this repo

**OSX**

- Visual Studio for MAC

## How it was built

Languages: **C#, HTML, CSS, TIScript**

Engine: **[Sciter](https://sciter.com/)**, the HTML rendering engine. [SciterSharp](https://github.com/MISoftware/SciterSharp) is a library with C# bindings for Sciter, letting you build cross-platform **desktop** apps with C#/MONO and write your UI in HTML/CSS3/Canvas.

You can simply view the HTML by opening file 'res/octodex.html' in [sciter.exe](https://github.com/c-smile/sciter-sdk/blob/master/bin/32/sciter.exe) or [OmniLite](https://github.com/MISoftware/OmniLite). **No need** to actually build the application, you can simply run the HTML as in a browser, but using one of those browsers specific for Sciter technology.

I've also made a simple PHP script that parses the [Octodex site](https://octodex.github.com/) HTML and outputs a JSON result with the list of the mascots images. The script is located at http://misoftware.com.br/cdn/octodexapi.php.

## Please hurl money at me.

Liked this app?

Maybe you may like my other app for designers: http://designarsenal.co/

What about we creating something together? I am always looking for projects where I can really come handy in helping in your development needs.

I am a full-stack developer and my main language/platform is C#/Azure. I also do cross-platform desktop software like this one! Check my tool for designer's productivity: http://designarsenal.co/

Don't hesitate [to get in touch](http://misoftware.com.br/Home/Services).

Glad we meet over here!