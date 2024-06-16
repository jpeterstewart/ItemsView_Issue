### This small app serves to illustrate a few issues with ItemsView and ListView and makes it easy to reproduce some bugs. You can easily add more items to the views and see the result directly.

#### ItemsView improves on ListView in that it doesn't have all the unnecessary padding between items. However, it has the following problems:

1) It gets excruciatingly slow after only adding a couple of hundred items.
2) After adding something like 1,000 items you can easily crash the application just by scrolling up and down a little. Perhaps it's not done building the view?

#### ListView is more stable and can quickly add 100,000 items or more. But it also has its problems:

1) After adding a large number of items, it overflows the lower boundary of the list and continues to display list items down to the bottom edge of the app. On my computer, the limit seems to be 52,451 items, regardless of the item size. The ListView overflows after adding item number 52,452.
2) So far, I haven't found a way to make the line spacing more compact.

