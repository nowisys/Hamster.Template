using Hamster.Plugin;
using Hamster.Plugin.Configuration;
using System;
using System.Xml;

namespace Hamster.Template
{
    public class Plugin : AbstractPlugin<PluginSettings>, IBindable
    {
        public void Bind(string name, object instance)
        {
            switch (name.ToLower())
            {
                default:
                    break;
            }
        }

        public void BindingComplete()
        {

        }

        public override void Configure(XmlElement element)
        {
            base.Configure(element);
        }

        public override void Init()
        {
            base.Init();
        }

        public override void Open()
        {
            base.Open();
        }

        public override void Close()
        {
            base.Close();
        }
    }
}
