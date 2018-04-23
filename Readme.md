# How to silently pass a parameter's value to a report


<p>This example demonstrates how to pass a <a href="http://help.devexpress.com/XtraReports/CustomDocument4812.aspx"><u>parameter</u></a>'s value to a report, prior to its generation and without prompting end-users to enter this value manually. </p><p>When there are no visible parameters in a report, their values are passed "silently" (without exposing the Parameters UI to end-users).</p><p>See also: <a href="https://www.devexpress.com/Support/Center/p/E960">E960</a>.</p>


<h3>Description</h3>

<p>To do this, add a parameter to a report, set the parameter&#39;s <strong>Modifiers</strong> property to <strong>Public</strong> and, the report&#39;s <strong>RequestParameters</strong> property to <strong>False</strong>. To hide a particular parameter, disable its <strong>Visible</strong> property.</p><p>After the report is created, the parameter&#39;s <strong>Value</strong> should be defined via code. This value will be used to create the report document, and no <strong>Parameters</strong> window will be shown to end-users.</p>

<br/>


