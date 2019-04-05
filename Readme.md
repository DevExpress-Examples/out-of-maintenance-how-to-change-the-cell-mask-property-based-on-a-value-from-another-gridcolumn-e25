<!-- default file list -->
*Files to look at*:

* **[Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))**
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to change the cell Mask property based on a value from another GridColumn


<p>Implement the CellTemplate for a grid column that you want to change the Mask property for. In this template, implement the  DataTemplate.Triggers. Based on the value from another column, set a necessary value for the Mask property. In the setter, use the TargetName equal to PART_Editor, this will allow you to find our editor in the template.</p>

<br/>


