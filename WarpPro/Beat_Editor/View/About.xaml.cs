using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Beat_Editor.Controller;
using Beat_Editor.Properties;

namespace Beat_Editor.View
{
	public partial class About : Window, IComponentConnector
	{
		private static readonly string licenseText = "WarpPro beat editor\n=====================\nCopyright © Warppro.com 2018\n\r\nNew in Release 1.2\r\n============\r\n\r\n* Increase audio playback buffer size to avoid glitches in audio playback\r\n* Smoothen playback progress indicator movement\r\n* Small UI fixes\r\n\r\nRelease 1.1\r\n=======\r\n\r\n* Allow moving the 1st beat after other beats and/or the BPM rate have been edited\r\n* Changed playback to scroll the waveform according to the adjusted beats, instead of the original beat scale\r\n* Bugfixes related to changing BPM rate\r\n\r\nRelease 1.0\r\n=======\r\n\r\nInitial release\n\n\nWarpPro License terms\n===============\n\n1. General\n=======\nWarpPro beat editor is commercial software for audio beat editing.\n\nBy using the application the user shall accept these license terms.\n\nThe free TRIAL version can be used for limited time for evaluating the application. After the limited trial period the user shall need to purchase a full license or use the application subject to reduced sound quality and/or other trial expiration constraints.\n\nThe free TRIAL version of the application can be distributed to 3rd parties, as far as the application is distributed in original, unmodified, full file format. Distributing modified versions of application or installer is prohibited.\n\nBy purchasing a FULL license the user shall receive rights to utilize the full feature set in a single computer. The user can't duplicate, sell, reassign or transfer the FULL license to 3rd parties.\n\nInternet connection will be required to use the application.\n\nThe application will automatically update itself over the internet connection.\n\nThe WarpPro developers reserve all rights to modify the application and change the application license terms without further notice.\n\n2. Data security statement\n=================\nThe WarpPro application stores and retrieves application license information to/from an internet server.\n\nThe WarpPro application does not collect personal information of the users or their computers. The application may however collect non-personalised statistical information about WarpPro application usage.\n\nThe application may collect and store name and email information from the users purchase 'full' application license. Reason for collecting this data is to allow handling customer support and reclamations cases.\n\n3. Third party software used in the application\n==============================\nThe WarpPro application uses the following 3rd party software modules subject to their original licenses:\n\nSoundTouch library \n---------------------\nSoundTouch Homepage: https://soundtouch.surina.net\n\nThis application uses SoundTouch library subject to commercial license, licensed to WarpPro.com.\n--\n\nNAudio library \n----------------\nNAudio Homepage: https://github.com/naudio/NAudio\n\nWarpPro links to NAudio library without modifying the original library. The NAudio license statement is as follows:\n\n\"Microsoft Public License(Ms-PL)\n\nThis license governs use of the accompanying software. If you use the software, you accept this license.If you do not accept the license, do not use the software.\n\n1. Definitions\n\nThe terms 'reproduce,' 'reproduction,' 'derivative works,' and 'distribution' have the same meaning here as under U.S. copyright law.\n\nA 'contribution' is the original software, or any additions or changes to the software.\n\nA 'contributor' is any person that distributes its contribution under this license.\n\n'Licensed patents' are a contributor's patent claims that read directly on its contribution.\n\n2. Grant of Rights\n\n(A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.\n\n(B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed patents to make, have made, use, sell, offer for sale, import, and/or otherwise dispose of its contribution in the software or derivative works of the contribution in the software.\n\n3. Conditions and Limitations\n\n(A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.\n\n(B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, your patent license from such contributor to the software ends automatically.\n\n(C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, and attribution notices that are present in the software.\n\n(D) If you distribute any portion of the software in source code form, you may do so only under this license by including a complete copy of this license with your distribution. If you distribute any portion of the software in compiled or object code form, you may only do so under a license that complies with this license.\n\n(E) The software is licensed 'as-is.' You bear the risk of using it. The contributors give no express warranties, guarantees or conditions. You may have additional consumer rights under your local laws which this license cannot change. To the extent permitted under your local laws, the contributors exclude the implied warranties of merchantability, fitness for a particular purpose and non-infringement.\"\n--\n\nid3ib library \n------------- \nid3lib Homepage: http://id3lib.sourceforge.net/\n\nWarpPro links to id3lib library without modifying the original library. The id3lib library is open-source software, licensed under the GNU Library General Public License(LGPL):\n\n\"GNU LESSER GENERAL PUBLIC LICENSE\n\nVersion 3, 29 June 2007\n\nCopyright © 2007 Free Software Foundation, Inc. <https://fsf.org/>\n\nEveryone is permitted to copy and distribute verbatim copies of this license document, but changing it is not allowed.\n\nThis version of the GNU Lesser General Public License incorporates the terms and conditions of version 3 of the GNU General Public License, supplemented by the additional permissions listed below.\n\n0. Additional Definitions.\n\nAs used herein, “this License” refers to version 3 of the GNU Lesser General Public License, and the “GNU GPL” refers to version 3 of the GNU General Public License.\n\n“The Library” refers to a covered work governed by this License, other than an Application or a Combined Work as defined below.\n\nAn “Application” is any work that makes use of an interface provided by the Library, but which is not otherwise based on the Library. Defining a subclass of a class defined by the Library is deemed a mode of using an interface provided by the Library.\n\nA “Combined Work” is a work produced by combining or linking an Application with the Library. The particular version of the Library with which the Combined Work was made is also called the “Linked Version”.\n\nThe “Minimal Corresponding Source” for a Combined Work means the Corresponding Source for the Combined Work, excluding any source code for portions of the Combined Work that, considered in isolation, are based on the Application, and not on the Linked Version.\n\nThe “Corresponding Application Code” for a Combined Work means the object code and/or source code for the Application, including any data and utility programs needed for reproducing the Combined Work from the Application, but excluding the System Libraries of the Combined Work.\n\n1. Exception to Section 3 of the GNU GPL.\n\nYou may convey a covered work under sections 3 and 4 of this License without being bound by section 3 of the GNU GPL.\n\n2. Conveying Modified Versions.\n\nIf you modify a copy of the Library, and, in your modifications, a facility refers to a function or data to be supplied by an Application that uses the facility (other than as an argument passed when the facility is invoked), then you may convey a copy of the modified version:\n\na) under this License, provided that you make a good faith effort to ensure that, in the event an Application does not supply the function or data, the facility still operates, and performs whatever part of its purpose remains meaningful, or\nb) under the GNU GPL, with none of the additional permissions of this License applicable to that copy.\n3. Object Code Incorporating Material from Library Header Files.\n\nThe object code form of an Application may incorporate material from a header file that is part of the Library. You may convey such object code under terms of your choice, provided that, if the incorporated material is not limited to numerical parameters, data structure layouts and accessors, or small macros, inline functions and templates (ten or fewer lines in length), you do both of the following:\n\na) Give prominent notice with each copy of the object code that the Library is used in it and that the Library and its use are covered by this License.\nb) Accompany the object code with a copy of the GNU GPL and this license document.\n4. Combined Works.\n\nYou may convey a Combined Work under terms of your choice that, taken together, effectively do not restrict modification of the portions of the Library contained in the Combined Work and reverse engineering for debugging such modifications, if you also do each of the following:\n\na) Give prominent notice with each copy of the Combined Work that the Library is used in it and that the Library and its use are covered by this License.\nb) Accompany the Combined Work with a copy of the GNU GPL and this license document.\nc) For a Combined Work that displays copyright notices during execution, include the copyright notice for the Library among these notices, as well as a reference directing the user to the copies of the GNU GPL and this license document.\nd) Do one of the following:\n0) Convey the Minimal Corresponding Source under the terms of this License, and the Corresponding Application Code in a form suitable for, and under terms that permit, the user to recombine or relink the Application with a modified version of the Linked Version to produce a modified Combined Work, in the manner specified by section 6 of the GNU GPL for conveying Corresponding Source.\n1) Use a suitable shared library mechanism for linking with the Library. A suitable mechanism is one that (a) uses at run time a copy of the Library already present on the user's computer system, and (b) will operate properly with a modified version of the Library that is interface-compatible with the Linked Version.\ne) Provide Installation Information, but only if you would otherwise be required to provide such information under section 6 of the GNU GPL, and only to the extent that such information is necessary to install and execute a modified version of the Combined Work produced by recombining or relinking the Application with a modified version of the Linked Version. (If you use option 4d0, the Installation Information must accompany the Minimal Corresponding Source and Corresponding Application Code. If you use option 4d1, you must provide the Installation Information in the manner specified by section 6 of the GNU GPL for conveying Corresponding Source.)\n5. Combined Libraries.\n\nYou may place library facilities that are a work based on the Library side by side in a single library together with other library facilities that are not Applications and are not covered by this License, and convey such a combined library under terms of your choice, if you do both of the following:\n\na) Accompany the combined library with a copy of the same work based on the Library, uncombined with any other library facilities, conveyed under the terms of this License.\nb) Give prominent notice with the combined library that part of it is a work based on the Library, and explaining where to find the accompanying uncombined form of the same work.\n6. Revised Versions of the GNU Lesser General Public License.\n\nThe Free Software Foundation may publish revised and/or new versions of the GNU Lesser General Public License from time to time. Such new versions will be similar in spirit to the present version, but may differ in detail to address new problems or concerns.\n\nEach version is given a distinguishing version number. If the Library as you received it specifies that a certain numbered version of the GNU Lesser General Public License “or any later version” applies to it, you have the option of following the terms and conditions either of that published version or of any later version published by the Free Software Foundation. If the Library as you received it does not specify a version number of the GNU Lesser General Public License, you may choose any version of the GNU Lesser General Public License ever published by the Free Software Foundation.\n\nIf the Library as you received it specifies that a proxy can decide whether future versions of the GNU Lesser General Public License shall apply, that proxy's public statement of acceptance of any version is permanent authorization for you to choose that version for the Library.\"\n--\n\nmp3lib library \n--------------- \nmp3lib Homepage: http://mp3libdotnet.sourceforge.net/\n\nWarpPro links to mp3lib library without modifying the original library. mp3lib license statement is as follows:\n\n\"This is free and unencumbered software released into the public domain. Anyone is free to copy, modify, publish, use, compile, sell, or distribute this software, either in source code form or as a compiled binary, for any purpose, commercial or non-commercial, and by any means. \n\nIn jurisdictions that recognize copyright laws, the author or authors of this software dedicate any and all copyright interest in the software to the public domain.We make this dedication for the benefit of the public at large and to the detriment of our heirs and successors.We intend this dedication to be an overt act of relinquishment in perpetuity of all present and future rights to this software under copyright law. \n\nTHE SOFTWARE IS PROVIDED AS IS, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. \n\nFor more information, please refer to<http://unlicense.org/>\"\n--\n\nFody/Costura\n---------------\nFody/Costura Homepage: https://github.com/Fody/Costura\n\nWarpPro uses Fody/Costura to package the application. The Fody/Costura license statement is as follows:\"\n\nThe MIT License\n\nCopyright(c) 2012 Simon Cropp and contributors\n\nPermission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files(the 'Software'), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:\n\nThe above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.\n\nTHE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.\"\n--\n\n - End of the license statements -";

		public About()
		{
			InitializeComponent();
			textVersion.Text = string.Format("WarpPro beat editor v{0} ({1}) - Copyright © Warppro.com 2018", App.VersionStr, Beat_Editor.Properties.Resources.BuildDate.Replace("\r\n", ""));
			string arg = ((LicenseController.Instance.LicenseLevel == 0) ? "TRIAL" : "FULL");
			textLicenseMode.Text = string.Format("License: {0} version", arg);
			textLicenseId.Text = string.Format("License ID: {0}", LicenseController.LocalLicenseId);
			textLicenseText.Text = licenseText;
		}

		private void buttonClose_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}