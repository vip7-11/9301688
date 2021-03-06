/*
 * FCKeditor - The text editor for Internet - http://www.fckeditor.net
 * Copyright (c) 2003-2010, CKSource - Frederico Knabben. All rights reserved.
 *
 * == BEGIN LICENSE ==
 *
 * Licensed under the terms of any of the following licenses at your
 * choice:
 *
 *  - GNU General Public License Version 2 or later (the "GPL")
 *    http://www.gnu.org/licenses/gpl.html
 *
 *  - GNU Lesser General Public License Version 2.1 or later (the "LGPL")
 *    http://www.gnu.org/licenses/lgpl.html
 *
 *  - Mozilla Public License Version 1.1 or later (the "MPL")
 *    http://www.mozilla.org/MPL/MPL-1.1.html
 *
 * == END LICENSE ==
 */

using System;

namespace FredCK.FCKeditorV2.FileBrowser
{
	public class TypeConfigList
	{
		private FileWorkerBase _FileWorker;
		private System.Collections.Hashtable _Types;

		public TypeConfigList( FileWorkerBase fileWorker )
		{
			_FileWorker = fileWorker;

			_Types = new System.Collections.Hashtable( 4 );
		}

		public TypeConfig this[ string typeName ]
		{
			get
			{
				if ( !_Types.Contains( typeName ) )
					_Types[ typeName ] = new TypeConfig( _FileWorker );

				return (TypeConfig)_Types[ typeName ];
			}
		}
	}
}
