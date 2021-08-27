<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622627/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2097)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BusyForm.cs](./CS/Busy/BusyForm.cs) (VB: [BusyForm.vb](./VB/Busy/BusyForm.vb))
* [Program.cs](./CS/Busy/Program.cs) (VB: [Program.vb](./VB/Busy/Program.vb))
* [ProgressControl.cs](./CS/Busy/ProgressControl.cs) (VB: [ProgressControl.vb](./VB/Busy/ProgressControl.vb))
<!-- default file list end -->
# How to update the ProgressBarControl from a separate thread


<p>Very often when you perform any operation in a background thread, it can be very useful to indicate to an end-user the current state of progress. To display the progress, the ProgressBarControl can be used. This example illustrates how to perform a file copy operation in a background thread, and display the progress on a main form.</p>

<strong>NOTE:</strong>
We have our built-in <a href="https://docs.devexpress.com/WindowsForms/10824/controls-and-libraries/forms-and-user-controls/splash-screen-manager/wait-form">Wait Form</a>. It is invoked in a background thread and is useful when it is required to indicate a long running task executed in the main thread. Please refer to the class description for more information.

We also have the following example that illustrates how to show progress by using this form: <a href="https://github.com/DevExpress-Examples/how-to-dynamically-change-a-wait-forms-labels-e3575">How to dynamically change Wait Form's labels</a>.


<b>See also:</b>

[DevExpress WinForms Troubleshooting - Asynchronous Programming](https://go.devexpress.com/CheatSheets_WinForms_Examples_T964838.aspx)



<br/>


