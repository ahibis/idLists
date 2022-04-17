# idLists
a special list of purposes for storing id.
the difference between this list and others is that it adds the added ids in ascending order and immediately hashes them into a string. 
It is easy to turn this list into a string and from a string to a list. 
The search and addition of elements takes place using binary search, which is why the speed of adding new elements is very high.
at this version list can keep id no more than 65 535. 
## api
```c#
new IdList(string hash = ""); // list create with hash O(n)
void idList.addId(int Id);  // add Id to list. O(n)
void idList.removeId(int Id) // remove Id from list. O(n)
bool idList.hasId(int Id) // check has Id on list. O(log(n))
string idList.toString() // return hash of list O(n)
List<int> idList.toList() // return Ids of List<id> O(n)
```

## ROADMAP
- [x] - add,remove,has methods
- [x] - speeding up the search by ascending distribution and using binary search
- [ ] - to store an id, use more than 1 letter
- [ ] - use approximation search instead of binary search
- [ ] - optimisation for big data
![image](https://user-images.githubusercontent.com/37046811/163733810-2cc22759-14eb-404b-8dce-6aa5676f2c81.png)
