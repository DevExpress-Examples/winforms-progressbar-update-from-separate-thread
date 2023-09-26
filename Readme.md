<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622627/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2097)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Progress Bar - Update the progress from a separate thread

This example shows how to perform a file copy operation in a background thread and indicate progress of the operation on the main form. The [WinForms Progress Bar](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.ProgressBarControl) control is used to communicate operation state and supply feedback to end users.

> **Note**
>
> You can also use the [WinForms Wait Form](https://docs.devexpress.com/WindowsForms/10824/controls-and-libraries/forms-and-user-controls/splash-screen-manager/wait-form) to indicate progress of time-consuming operations. The Wait Form runs in a separate thread and provides feedback to users regarding an application’s state.


## Files to Review

* [BusyForm.cs](./CS/Busy/BusyForm.cs) (VB: [BusyForm.vb](./VB/Busy/BusyForm.vb))
* [ProgressControl.cs](./CS/Busy/ProgressControl.cs) (VB: [ProgressControl.vb](./VB/Busy/ProgressControl.vb))


## See Also

* [How to dynamically change Wait Form's labels](https://github.com/DevExpress-Examples/how-to-dynamically-change-a-wait-forms-labels-e3575)
* [DevExpress WinForms Troubleshooting - Asynchronous Programming](https://go.devexpress.com/CheatSheets_WinForms_Examples_T964838.aspx)


