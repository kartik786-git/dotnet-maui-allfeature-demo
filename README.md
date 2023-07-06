# dotnet-maui-allfeature-demo

.Net Maui | List Binding | MVVM advance feature

list binding github repo
https://github.com/kartik786-git/dotnet-maui-allfeature-demo

.net maui | .net multi platform app | window | android | IOS
https://www.youtube.com/watch?v=qj6d5d4BZOE

android emulator setup
https://youtu.be/nXQ34-m-8QA

Windows Subsystem for Android| Winodows 11 | .Net Maui App
https://www.youtube.com/watch?v=YLmhLKk28XE


Create .net maui app
create model
implement blog model
create view model 
create services
implement service
consume service in app
install Comunity toolkit.mvvm package
inherit observalobject
overveiw ObservableProperty
implement ObservableProperty
overveiw RelayCommand
implement RelayCommand
overview of advnce mvvm
automatic code generation with mvvm
added reference view and view model in xaml file
create RefreshView
create CollectionView
binding list along with image(list of blogs)
BindingContext in code behiind file
resolve dependency in .net maui

The .NET Multi-platform App UI (.NET MAUI) CollectionView is a view for presenting lists of data using different layout specifications. It aims to provide a more flexible, and performant alternative to ListView.

CollectionView should be used for presenting lists of data that require scrolling or selection. A bindable layout can be used when the data to be displayed doesn't require scrolling or selection. For more information, see BindableLayout.

CollectionView and ListView differences
While the CollectionView and ListView APIs are similar, there are some notable differences:

CollectionView has a flexible layout model, which allows data to be presented vertically or horizontally, in a list or a grid.
CollectionView supports single and multiple selection.
CollectionView has no concept of cells. Instead, a data template is used to define the appearance of each item of data in the list.
CollectionView automatically utilizes the virtualization provided by the underlying native controls.
CollectionView reduces the API surface of ListView. Many properties and events from ListView are not present in CollectionView.
CollectionView does not include built-in separators.
CollectionView will throw an exception if its ItemsSource is updated off the UI thread.

The .NET Multi-platform App UI (.NET MAUI) CollectionView includes the following properties that define the data to be displayed, and its appearance:

ItemsSource, of type IEnumerable, specifies the collection of items to be displayed, and has a default value of null.
ItemTemplate, of type DataTemplate, specifies the template to apply to each item in the collection of items to be displayed.
These properties are backed by BindableProperty objects, which means that the properties can be targets of data bindings.

CollectionView defines a ItemsUpdatingScrollMode property that represents the scrolling behavior of the CollectionView when new items are added to it. For more information about this property, see Control scroll position when new items are added.

CollectionView supports incremental data virtualization as the user scrolls. For more information, see Load data incrementally.

Populate a CollectionView with data
A CollectionView is populated with data by setting its ItemsSource property to any collection that implements IEnumerable. By default, CollectionView displays items in a vertical list.

ItemsSource property to an IEnumerable collection. In XAML, this is achieved with the Binding markup extension:

For information on how to change the CollectionView layout, see Specify CollectionView layout. For information on how to define the appearance of each item in the CollectionView, see Define item appearance. For more information about data binding, see Data binding.

Define item appearance

The appearance of each item in the CollectionView can be defined by setting the CollectionView.ItemTemplate property to a DataTemplate:



Load data incrementally
CollectionView supports incremental data virtualization as the user scrolls. This enables scenarios such as asynchronously loading a page of data from a web service, as the user scrolls. In addition, the point at which more data is loaded is configurable so that users don't see blank space, or are stopped from scrolling.

CollectionView defines the following properties to control incremental loading of data:

RemainingItemsThreshold, of type int, the threshold of items not yet visible in the list at which the RemainingItemsThresholdReached event will be fired.
RemainingItemsThresholdReachedCommand, of type ICommand, which is executed when the RemainingItemsThreshold is reached.
RemainingItemsThresholdReachedCommandParameter, of type object, which is the parameter that's passed to the RemainingItemsThresholdReachedCommand.
CollectionView also defines a RemainingItemsThresholdReached event that is fired when the CollectionView is scrolled far enough that RemainingItemsThreshold items have not been displayed. This event can 


