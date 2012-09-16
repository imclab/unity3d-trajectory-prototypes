#region MIT License

// ResourceBase.cs
// Version: 0.01
// Last Modified: 2012/09/16 15:59
// Created: 2012/09/05 6:19
// 
// Author: Jing-Jun Wei
// Mail: jingjunwei@outlook.com
// Homepage: http://jingjunwei.github.com/unity3d-trajectory-prototypes/
// 
// MIT License
// Copyright (c) 2012 Jing-Jun Wei
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

#endregion

#region Usings

using UnityEngine;
using System;
using Object = UnityEngine.Object;

#endregion

namespace KeigunGi.General
{
    /// <summary>
    /// �꥽�`���v�S�ΙC�ܤ����d�����٩`�����饹
    /// </summary>
    public class ResourceBase
    {
        protected virtual T ConvertTo<T>(Object objectOrigin) where T: Object
        {
            var objectConverted = objectOrigin as T;

            bool isConvertFailed = objectConverted == null;
            if(isConvertFailed)
            {
                throw new InvalidCastException();
            }

            return objectConverted;
        }

        /// <summary>
        /// Load a file from any "Resrouces" directories
        /// on the specified path, 
        /// then output loaded object with a specified type.
        /// </summary>
        /// <typeparam name="T"> Type of loaded object </typeparam>
        /// <param name="resource"> output loaded object </param>
        /// <returns></returns>
        protected virtual T Load<T>(string path) where T: Object
        {
            Object objectLoaded = Resources.Load(path);

            bool isLoadFailed = objectLoaded == null;
            if(isLoadFailed)
            {
                throw new NullReferenceException();
            }

            var objectConverted = ConvertTo<T>(objectLoaded);
            return objectConverted;
        }
    }
}