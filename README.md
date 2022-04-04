<h1 align="center">Hello World! 🚀, I'm Cameron</h1>
<h3 align="center">A Full-Stack Software Developer from The Isle of Man 🇮🇲</h3>

First attempt at Question One. Still need to do Questions 2 & 3. I'll also go back and see if I can refactor Question One anymore, this is just a first pass I managed to get done while on the plane back from London.

Thanks,
Cameron.

<h3>Question 1: Change Log</h3>
<ul>
  <li>Created Encoding Class</li>
  <li>Moved all provided functionallity into new static class abstracting where possible by making methods private</li>
  <li>Fixed explicit casting error</li>
  <li>Fixed switch case statement</li>
  <li>Fixed Array Out of Bounds errors</li>
  <li>Fixed naming conventions </li>
  <li>Refactored logic in Decode() in order to eliminate whitespace so when comparing values they would pass tests</li>
  <li>Created some basic NUnit Tests</li>
</ul>

<h3>Question 2: Usage Guide</h3>
To play HighCard firstly you must create a new game instance like so:

```C#
HighCard name = new();
```

You can use parameters to alter how the game plays. There are 5 parameters with the types as shown below in order:

```C#
HighCard name = new(string[] range, string[] sets, bool compareSets, bool noTie, bool wildcard);
```

All parameters are optional, you can create an instance of HighCard with all or no parameters:

```C#
HighCard gameOne = new();
HighCard gameTwo = new(range, sets, true, true, true);
```

NOTE: To skip range/sets parameters, use Null as the input, it will be ignored. Any missing paramaters will be set to default:

```C#
// Bool params are set to default as only two are declared:
HighCard gameOne = new(range, sets);

// Range & Sets params are ignored and Bool params are declared:
HighCard gameTwo = new(null, null, true, true, true);
```

- 📫 Email: **me@cameronquayle.com**

<h3 align="left">Connect with me:</h3>
<p align="left">
<a href="https://linkedin.com/in/https://www.linkedin.com/in/robert-cameron-quayle-1b49a6133" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="https://www.linkedin.com/in/robert-cameron-quayle-1b49a6133" height="30" width="40" /></a>
</p>

