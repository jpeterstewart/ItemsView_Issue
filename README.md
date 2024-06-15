## This project illustrates some issues with ItemsView and ListView and makes it easy to reproduce some bugs. You can easily add more itmes to the views and directly see the result.

### ItemsView improves on ListView in that it doesn't have all the unnecessary padding between each item. However, it has the following problems:

1) It gets excruciatingly slow fter only adding a couple of hundred items.
2) After adding something like 1,000 items you can easily crash the application just by scrolling up and down a little. Perhaps it's not done initializing?

### ListView is more stable and can quickly add a 100,000 items or more. But it also has its problems:

1) After adding a large number of items it overfloes the lower boundary of the list and continues to display listitems down to the bottom edge of the app.
2) So far, I haven't been able to find a way to make the line spacing more compact.

