//
// SimEntity.cs
//  
// Author(s):
//       Alessio Parma <alessio.parma@gmail.com>
// 
// Copyright (c) 2012-2016 Alessio Parma <alessio.parma@gmail.com>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace DIBRIS.Dessert.Core
{
    using System.Diagnostics.Contracts;

    /// <summary>
    ///   Represents an entity that belongs to a specific environment.
    ///   An entity can only be "used" in the environment it belongs to.
    /// </summary>
    public abstract class SimEntity
    {
        /// <summary>
        ///   Stores the environment in which this entity was created.
        /// </summary>
        readonly SimEnvironment _env;

        /// <summary>
        ///   Creates a new entity (with given name) belonging to given environment.
        /// </summary>
        /// <param name="env">The environment this entity will belong to.</param>
        internal SimEntity(SimEnvironment env)
        {
            _env = env;
        }

        #region Public Members

        /// <summary>
        ///   Returns the environment in which this entity was created.
        /// </summary>
        [Pure]
        public SimEnvironment Env
        {
            get { return _env; }
        }

        #endregion
    }
}