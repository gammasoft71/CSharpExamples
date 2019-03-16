# System.Windows.Forms (Winforms) Examples

[This folder](.) contains Winforms controls examples.

## Hello World

* ["Hello World"](./HelloWorldForm/README.md) The classic first application HelloWorld with Label control.
* ["Hello World (MessageBox)"](./HelloWorldMessageBox/README.md) The classic first application HelloWorld with MessageBox control.
* ["Hello World (Paint)"](./HelloWorldPaint/README.md) The classic first application HelloWorld with GDI+ drawing objects.

## Application

* [Application](./Application/README.md) shows how to create an Application with Application class.
* [ApplicationEnableVisualStyle](ApplicationEnableVisualStyle/README.md) demonstrates the use of System.Windows.Forms.Application.EnableVisualStyle method.
* [ApplicationIcon](ApplicationIcon/README.md) shows how to set application icon in project properties.

## Common Controls

* [Button](./Button/README.md) represents a Windows button control.
* [CheckBox](./CheckBox/README.md) represents a Windows CheckBox control.
* [CheckedListBox](CheckedListBox/README.md) represents a Windows control to display a list of items.
* [ComboBox](ComboBox/README.md) represents a Windows combo box control.
* [Control](./Control/README.md) refines the base class for controls, which are components with visual representation.
* [DateTimePicker](DateTimePicker/README.md) represents a Windows control that allows the user to select a date and a time and to display the date and time with a specified format.
* [DomainUpDown](DomainUpDown/README.md) represents a Windows spin box (also known as an up-down control) that displays string values.
* [HScrollBar](HScrollBar/README.md) represents a standard Windows horizontal scroll bar.
* [Label](Label/README.md) represents a standard Windows label.
* [LinkLabel](LinkLabel/README.md) represents a Windows label control that can display hyperlinks.
* [ListBox](ListBox/README.md) represents a Windows control to display a list of items.
* [ListView](ListView/README.md) represents a Windows list view control, which displays a collection of items that can be displayed using one of four different views.
* [MaskedTextBox](MaskedTextBox/README.md) uses a mask to distinguish between proper and improper user input.
* [MonthCalendar](MonthCalendar/README.md) specifies values for navigating among accessible objects.
* [NotifyIcon](NotifyIcon/README.md) specifies a component that creates an icon in the notification area. This class cannot be inherited.
* [NumericUpDown](NumericUpDown/README.md) represents a Windows spin box (also known as an up-down control) that displays numeric values.
* [PictureBox](PictureBox/README.md) represents a Windows picture box control for displaying an image.
* [ProgressBar](./ProgressBar/README.md) represents a Windows progress bar control.
* [RadioButton](./RadioButton/README.md) enables the user to select a single option from a group of choices when paired with other RadioButton controls.
* [RichTextBox](./RichTextBox/README.md) represents a Windows rich text box control.
* [Splitter](Splitter/README.md) represents a splitter control that enables the user to resize docked controls. Splitter has been replaced by SplitContainer and is provided only for compatibility with previous versions.
* [TextBox](./TextBox/README.md) represents a Windows text box control.
* **ToolTip** Represents a small rectangular pop-up window that displays a brief description of a control's purpose when the user rests the pointer on the control.
* [TrackBar](./TrackBar/README.md) represents a standard Windows track bar.
* **TreeView** displays a hierarchical collection of labeled items, each represented by a TreeNode.
* [VScrollBar](VScrollBar/README.md) represents a standard Windows vertical scroll bar.
* **WebBrowser** enables the user to navigate Web pages inside your form.

## Containers

* [FlowLayoutPanel](./FlowLayoutPanel/README.md) represents a panel that dynamically lays out its contents horizontally or vertically.
* [Form](./Form/README.md) represents a window or dialog box that makes up an application's user interface.
* [GroupBox](./GroupBox/README.md) represents a Windows control that displays a frame around a group of controls with an optional caption.
* [Panel](./Panel/README.md) used to group collections of controls.
* [SplitContainer](./SplitContainer/README.md) represents a control consisting of a movable bar that divides a container's display area into two resizable panels.
* [TabControl](./TabControl/README.md) manages a related set of tab pages.
* **TableLayoutPanel** represents a panel that dynamically lays out its contents in a grid composed of rows and columns.

## Menus and Toolbars

* **ContextMenuStrip** represents a shortcut menu.
* [MainMenu](MainMenu/README.md) provides a main menu system for a form.
* [MenuStrip](MenuStrip/README.md) provides a menu system for a form.
* **StatusStrip** represents a Windows status bar control.
* **ToolStrip** provides a container for Windows toolbar objects.
* **ToolStripContainer** provides panels on each side of the form and a central panel that can hold one or more controls.

## Datas

* **BindingNavigator** represents the navigation and manipulation user interface (UI) for controls on a form that are bound to data.
* **BindingSource** encapsulates the data source for a form.
* **Chart** 
* **DataGridView** displays data in a customizable grid.
* **DataSet** 

## Components

* **BackgroundWorker** executes an operation on a separate thread.
* **DirectoryEntry** The DirectoryEntry class encapsulates a node or object in the Active Directory Domain Services hierarchy.
* **DirectorySearcher** performs queries against Active Directory Domain Services.
* **ErrorProvider** provides a user interface for indicating that a control on a form has an error associated with it.
* **EventLog** provides interaction with Windows event logs.
* **FileSystemWatcher** listens to the file system change notifications and raises events when a directory, or file in a directory, changes.
* **HelpProvider** provides pop-up or online Help for controls.
* **ImageList** provides methods to manage a collection of Image objects. This class cannot be inherited.
* **MessageQueue** provides access to a queue on a Message Queuing server.
* **PerformanceCounter** represents a Windows NT performance counter component.
* **Process** provides access to local and remote processes and enables you to start and stop local system processes.
* **SerialPort** represents a serial port resource.
* **ServiceControler** represents a Windows service and allows you to connect to a running or stopped service, manipulate it, or get information about it.
* [Timer](./TimerForm/README.md) implements a timer that raises an event at user-defined intervals. This timer is optimized for use in Windows Forms applications and must be used in a window.

## Printing

* **PageSetupDialog** enables users to change page-related print settings, including margins and paper orientation. This class cannot be inherited.
* **PrintDialog** lets users select a printer and choose which sections of the document to print from a Windows Forms application.
* **PrintDocument** defines a reusable object that sends output to a printer, when printing from a Windows Forms application.
* **PrintPreviewControl** represents the raw preview part of print previewing from a Windows Forms application, without any dialog boxes or buttons. Most PrintPreviewControl objects are found on PrintPreviewDialog objects, but they do not have to be.
* **PrintPreviewDialog** represents a dialog box form that contains a PrintPreviewControl for printing from a Windows Forms application.

## Dialogs

* [ColorDialog](./ColorDialog/README.md) represents a common dialog box that displays available colors along with controls that enable the user to define custom colors.
* [FolderBrowserDialog](./FolderBrowserDialog/README.md) prompts the user to select a folder. This class cannot be inherited.
* [FontDialog](./FontDialog/README.md) prompts the user to choose a font from among those installed on the local computer.
* [MessageBox](./MessageBox/README.md) displays a message window, also known as a dialog box, which presents a message to the user. It is a modal window, blocking other actions in the application until the user closes it. A MessageBox can contain text, buttons, and symbols that inform and instruct the user.
* [OpenFileDialog](./OpenFileDialog/README.md) displays a standard dialog box that prompts the user to open a file.
* [SaveFileDialog](./SaveFileDialog/README.md) prompts the user to select a location for saving a file.

## Events

* [ApplicationIdle](./ApplicationIdle/README.md) shows how to create an Application with Application class and Idle event.
* [MouseEvent](./MouseEvent/README.md) demonstrates the use of some mouse events.
* [EnableChangedEvent](./EnableChangedEvent/README.md) demonstrates the use of System.Windows.Forms.Control.EnableChaned event.
* [FontChangedEvent](./FontChangedEvent/README.md) demonstrates the use of System.Windows.Forms.Control.FontChaned event.
* [FormClick](./FormClick/README.md) demonstrates the use of System.Windows.Forms.Form control and Click event.
* [WndProc](./WndProc/README.md) demonstrates the use of System.Windows.Forms.Control.WndProc method.

## Other

* [Button2](./Button2/README.md) demonstrates the use of System.Windows.Forms.Button control.
* [ColoredForms](./ColoredForms/README.md) demonstrates the use of System.Windows.Forms.Form control and System.Drawing.Color class.
* [ColoredTabPages](./ColoredTabPages/README.md) demonstrates the use of System.Windows.Forms.TabControl and colored System.Windows.Forms.TabPage controls.
* [DataFormatsGetFormat](./DataFormatsGetFormat/README.md) demonstrates the use of System.Windows.Forms.DataFormats.GetFormat method.
* [GroupBoxAndCheckBox](./GroupBoxAndCheckBox/README.md) demonstrates the use of System.Windows.Forms.GroupBox and System.Windows.Forms.CheckBox controls.
* [GroupBoxAndRadioButton](./GroupBoxAndRadioButton/README.md) demonstrates the use of System.Windows.Forms.GroupBox and System.Windows.Forms.RadioButton controls.
* [LabelsAndUnicodeText](./LabelsAndUnicodeText/README.md) demonstrates the use of System.Windows.Forms.Label control and Unicode text.
* [Lines](./Lines/README.md) demonstrates the use of System.Windows.Forms.Label control to draw simple lines.
* [SomeControls](./SomeControls/README.md) demonstrates the use of some controls.
* [StopwatchForm](./StopwatchForm/README.md) demonstrates the use of Stopwatch class, Label and Button controls.
* [SystemSound](./SystemSound/README.md) demonstrates the use of System.Media.SystemSound component.
* [All](.) You can see all examples here. 
