# PrimeMultiplicatitonTable
C# console application to output prime number multiplication table

To run open project in visual studio, outputs to console.

I am pleased with prime number generator, I wasnt too sure how to implement it at first, so went through quite few online posts explaining,how prime numbers are generated and various tips to get best performance, such as skipping even numbers after 2 and that only time triplet prime occurs is at 5 7 9 , after that 4 digits can be skipped everytime twin primes are found.
I've implemented all of those suggestions, because I  thought that prime generator would have biggest performance impact.

But as it turns out multiplication is the slower process out of two, or at least my implementation. 
If I had more time I would try to multiply single row and display it before multiplying second row and so on.
That way multiplication table wouldnt be created all at once and would require less time/resources to be created.
Trying to multiply 100,000 primes at once will cause list to use more than 2gb memory and error will be thrown, that can be eliminated by targeting 64 bit OS, but will cause serious performance issues.

This week was filled with deadlines and I spent weekend away with family.
So there is literally no more time to try and modify the way multiplication is performed, since we were asked to submit by Monday.

Aistis
