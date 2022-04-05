For Question Two, I started off by taking a step back and analysing what was being asked of me. The requirements, the constraints and then wrote down a high-level overview on my notepad (bullet-points).

Apart from the "Scope" which was defined in the question's wording, the only other requirement/constraint that I could seem to think of was the fact that within a deck, it should be impossible to deal the exact same card twice, value & set.

So with all this in mind I headed to my whiteboard to visualize how I was going to make this work. I started by considering the four pillars of Object Orientated Development: Abstraction, Encapsulation, Inheritance & Polymorphism.

Based off the Scope and question wording, I determined that what was mainly being asked of me was to create something polymorphic, while abstracting where possible.

As stated, the project needs to be able to support multiple decks and deck ranges (20 was specified in this case).

Straight away, my first thought is that this needs to be an instantiable class template. Capable of taking custom inputs which modify it's behaviour, meaning that from this one class, we could create unlimited versions of HighCard with different value ranges, sets and optional functionality such as the Wildcard.

I started off by creating a new Namespace just as a pre-caution, then started structuring my class. I did make some assumptions at this stage which directly influenced my design process. I assumed that from what was being asked and the scope, that we will always know the length of any custom range/sets we plan on using and also, due to the usage of Console.WriteLine(); within the source code that this was simply a console based application, therefore I decided to continue desiging/refactoring as such by logging everything instead of returning.

After creating my class, I then started to think about how it was going to recieve these custom ranges/sets of data. The obvious answer being a Constructor, more specifically, Constructor overloading. However, with all the functionallity being asked the amount of constructors started to get out of hand and I then decided to refactor down to just one Constructor with optional parameters and default values, overall making the code a lot cleaner I think.

Next, I had to think about what data types the constructor was actually going to take. This was an important decision, as it would be the basis of most of the functionality and capabilities within the class. I considered Lists, however decided on using Arrays due ot the assumptions that, we know the size of our data, we're not dynamically changing it and it's only being assigned once when the instance is constructed to a private field. Also worth mentioning at this stage, I also deemed properties were unnecessary due to the fact that we're not getting/setting, therefore I just stayed with private fields which also made the code alot cleaner.

As we needed to be able to compare values to determine who has the higher card, I initially thought of using an int array. I then realised that not all cards have numbers, some are ace's, jacks, queens and kings, which would have to be stored as strings. I realised that I could utilise array indexers for my comparisons as long as the values were stored in order, this also worked out perfectly for custom ranges and sets. I generated random numbers/sets based of the Length of the range/set data provided, comparing the two values then printed out which was higher and the assossiated value within the Array, for example: 0=Ace 1=2 2=3 and so on. This scaled to whatever size of data sets provided to the constructor.
