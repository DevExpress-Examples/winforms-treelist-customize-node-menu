<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638402/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E847)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WinForms TreeList - Customize node context menu

This example demonstrates how to handle the [PopupMenuShowing](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.PopupMenuShowing) event to add new commands to the node menu:

```csharp
private void treeList1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
    if(e.Menu is TreeListNodeMenu) {
        treeList1.FocusedNode = ((TreeListNodeMenu)e.Menu).Node;
        e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Edit", bbEdit_ItemClick));
        e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Add child", bbAddChild_ItemClick));
        e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete", bbDelete_ItemClick));
    }
}
```


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))


## Documentation

* [Add Custom Menu Items to the Standard Menus](https://docs.devexpress.com/WindowsForms/5701/controls-and-libraries/tree-list/feature-center/context-menus/add-custom-menu-items-to-the-standard-menus)
* [TreeList Context Menus](https://docs.devexpress.com/WindowsForms/322/controls-and-libraries/tree-list/feature-center/context-menus)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-customize-node-menu&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-customize-node-menu&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
