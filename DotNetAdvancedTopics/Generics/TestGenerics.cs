using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetAdvancedTopics.Generics
{
    class TestGenerics
    {

        public TestGenerics()
        {
            #region String Format
            Generics<string> Name = new Generics<string>();
            Name.Value = "String Object";
            Name.MyGenericMethod<string>("Jagadeesh");
            Name.AddItemToCollection("Jagadeesh");
            #endregion

            #region int Format
            Generics<int> Number = new Generics<int>();
            Number.Value = 1;
            Number.MyGenericMethod(1);
            Number.AddItemToCollection(2);
            #endregion

            #region Bool Format
            Generics<bool> BooleanFormat = new Generics<bool>();
            BooleanFormat.Value = true;
            BooleanFormat.MyGenericMethod<bool>(true);
            BooleanFormat.AddItemToCollection(false);
            #endregion
        }
    }

   
}
