# Markdown Table Generator for Notepad++

This is a simple Notepad++ plugin which gives you an interface for creating tables thats a little easier on the eyes. 

To install, download the latest release or compile from source. Add the `.dll` to your Notepad++ plugins folder `Program Files/Notepad++/plugins`.

To use, click on the icon ![icon](https://github.com/TastyGod/MarkdownTableGenerator/blob/master/MarkdownTableGenerator/Resources/spreadshett.png) that is now on your toolbar.

![interface](/interface.gif)

![interface](/fill.gif)

The buttons are pretty self explanitory. The `:---`, `---:`, and `:---:` buttons enter their contents into the cells you select. The `Insert` button puts your table as markdown where your cursor in Notepad++ is currently at. The `Fill` button takes the markdown table you have selected and inserts it into the interface table. Note: `Fill` will produce an error if your selection is not the same table format as the plugin generates.

Here is an example of the output:

```
| Hello | This is | A Header | 
| :---: | :---: | :---: | 
| and | here | are | 
| some |  |  | 
|  | contents! |  | 


```

| Hello | This is | A Header | 
| :---: | :---: | :---: | 
| and | here | are | 
| some |  |  | 
|  | contents! |  | 

