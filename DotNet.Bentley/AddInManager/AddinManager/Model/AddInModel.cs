using DotNet.MVVM.Model;
using DotNet.MVVM;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace AddInManager.Model
{
    public class AddInModel : ObservableObject
    {
        private AddInModel m_Parent;
        private string m_Name;
        private string m_Path;
        private bool m_IsExpand;
        private ObservableCollection<AddInModel> m_Childs;
        private MethodInfo m_Method;

        public AddInModel Parent
        {
            get
            {
                return m_Parent;
            }

            set
            {
                m_Parent = value;
                this.RaisePropertyChanged(nameof(Parent));
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
                this.RaisePropertyChanged(nameof(Name));
            }
        }

        public string Path
        {
            get
            {
                return m_Path;
            }

            set
            {
                m_Path = value;
                this.RaisePropertyChanged(nameof(Path));
            }
        }

        public bool IsExpand
        {
            get
            {
                return m_IsExpand;
            }

            set
            {
                m_IsExpand = value;
                this.RaisePropertyChanged(nameof(IsExpand));
            }
        }

        public ObservableCollection<AddInModel> Childs
        {
            get
            {
                return m_Childs;
            }

            set
            {
                m_Childs = value;
                this.RaisePropertyChanged(nameof(Childs));
            }
        }

        public MethodInfo Method
        {
            get
            {
                return m_Method;
            }

            set
            {
                m_Method = value;
                this.RaisePropertyChanged(nameof(Method));
            }
        }

        public AddInModel()
        {
            this.IsExpand = true;
            this.Childs = new ObservableCollection<AddInModel>();
        }
    }
}
