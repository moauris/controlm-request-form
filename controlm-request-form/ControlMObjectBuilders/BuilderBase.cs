using controlm_request_form.BaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlm_request_form.ControlMObjectBuilders
{
    public abstract class BuilderBase
    {
        #region Constructors

        #endregion
        #region Properties

        #endregion
        #region Methods
        public abstract bool Validate();
        public abstract void Populate(string Property, object Value);
        public abstract bool TryBuild(out ControlMObjectBase controlMObject);
        #endregion
        #region Events
        
        #endregion
    }
}
