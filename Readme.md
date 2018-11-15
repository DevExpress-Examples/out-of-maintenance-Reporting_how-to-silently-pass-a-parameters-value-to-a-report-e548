<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to silently pass a parameter's value to a report


<p>This example demonstrates how to pass a <a href="http://help.devexpress.com/XtraReports/CustomDocument4812.aspx"><u>parameter</u></a>'s value to a report, prior to its generation and without prompting end-users to enter this value manually. </p><p>When there are no visible parameters in a report, their values are passed "silently" (without exposing the Parameters UI to end-users).</p><p>See also: <a href="https://www.devexpress.com/Support/Center/p/E960">E960</a>.</p>


<h3>Description</h3>

<p>To do this, add a parameter to a report, set the parameter&#39;s <strong>Modifiers</strong> property to <strong>Public</strong>, and disable the parameter&#39;s <strong>Visible</strong> property.</p><p>Then, when the report document is created, the parameter&#39;s <strong>Value</strong> is passed to it silently.</p>

<br/>


