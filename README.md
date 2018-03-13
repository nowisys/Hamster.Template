# Hamster.Template

Template providing the core structure of a new plugin for openHAMSTER. Used to bootstrap initial development steps.
***
## Usage
To use the template within your CLI you have to install the template with given routine: 

`dotnet new --install <path_to_template_root>`

To create a new plugin you can run the following command:

`dotnet new hamster -n <project_name> -o <output_directory>`

-n and -o are examples. Further explanation of the `dotnet new` command can be found here: https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore2x

After initializing your Plugin Project rename `Plugin.cs` to an appropriate class name repesenting the functionality of the Plugin (e.g., Web, Data, Scheduler, Messaging, etc.).
***
## Components
### Plugin
A Plugin is responsible of providing additional functionality to meet functional and non-functional requirements. A reference to *Hamster.Plugin* is required.

To get integrated by openHAMSTER, the Plugin has to follow a specific lifecycle, which can be inherited from *Hamster.Plugin.AbstractPlugin<?PluginSettings>*:

1. Constructor - Kernel provides relevant objects as parameters
2. Properties - Kernel provides relevant objects for public properties (e.g., a Logger instance)
3. Configure* - Uses provided PluginSettings.cs to configure Plugin
4. Bind** - Publishes any in hamster.xml configured Binding
5. BindingComplete** - Called at the end of Bind()
6. Init - Called by Kernel to invoke initialisation of the Plugin
7. Open - Called by Kernel to signal Plugin to begin to work
8. Close - Called by Kernel to signal Plugin to shutdown pending jobs

\* provided by IXmlConfigurable \
** provided by IBindable

### PluginSettings

The class *PluginSettings* can be used to define the structure of a well-formed XML document to provide additional Properties used within the Configure() lifecycle step. Please keep in mind to update the namespace of the xml document.