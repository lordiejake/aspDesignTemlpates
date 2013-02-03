<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    
    <script type="text/javascript">
    function LoadImage(path, img) {
        imgPrev = document.images[img];
        imgPrev.src = path;
        }
</script>
    <style type="text/css">
        #fleUpload
        {
            width: 359px;
        }
        .Gridview
        {
            margin-right: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
		
			<div id="logo">
				<h1> <a href="#"></a></h1>
			</div>		
			
			<div id="menu">
				<ul>
					<li><a href="#">Home</a>
					    <ul>
					        <li><a href="#">CENCOM blogs</a></li>
					        <li><a href="#">CAS blogs</a></li>
					        <li><a href="#">CED blogs</a></li>
					        <li><a href="#">CN blogs</a></li>
					        <li><a href="#">CBDEM blogs</a></li>
		                    <li><a href="#">CHEFS blogs</a></li>
		   	                <li><a href="#">CIT blogs</a></li>
					    </ul>
					</li>
					    
					<li><a href="#">Contact us</a>
					     <ul>
					        <li><a href="#">Telephone #</a></li>
					        <li><a href="#">Cellphone #</a></li>
					        <li><a href="#">Email Address</a></li>
					        <li><a href="#">Location</a></li>
					
					    </ul>
					</li>
					<li><a href="#">Services</a>
					     <ul>
					        <li><a href="#">Programming Tutorials</a></li>
					        <li><a href="#">Solving Tutorials</a></li>
					        <li><a href="#">Chemistry Tutorials</a></li>
					        <li><a href="#">WEB tutorials</a></li>
					        <li><a href="#">Guitar tutorials</a></li>
		                    <li><a href="#">Piano Tutorials</a></li>
		   	                <li><a href="#">Drums Tutorials</a></li>
					    </ul>
					</li>
					<li><a href="#">Register</a>
					     <ul>
					        <li><a href="loginForm.aspx?">Online Registration</a></li>
					    </ul>
					</li>
					<li><a href="#">Information</a>
					     <ul>
					        <li><a href="#">CENCOM blogs</a></li>
					        <li><a href="#">CAS blogs</a></li>
					        <li><a href="#">CED blogs</a></li>
					        <li><a href="#">CN blogs</a></li>
					        <li><a href="#">CBDEM blogs</a></li>
		                    <li><a href="#">CHEFS blogs</a></li>
		   	                <li><a href="#">CIT blogs</a></li>
		   	                
					    </ul>
					</li>
				</ul>
			</div>
		</div>
		
		<div id="logx">
		   
		   <h4>Csharp Forums: Welcome:  
               <asp:Label ID="lblwelcome" runat="server" Text="Label"></asp:Label></h4>
		   <div id = "part">
		   <img alt="" src="orange-circuit940x198.jpg" 
                    style="width: 508px; height: 110px" /><img alt="" src="orange-circuit940x198.jpg" 
                    style="width: 451px; height: 110px" /></div>
		   </div>
		   <div id = "part2">
		        </div>
            
		</div>
	<div id="wrapper">
		<div id="page">
		<div id="page-bg">
			<div id="sidebar1" class="sidebar">
				<ul>
					
					<li>
					<h2>Categories</h2>
					<div id="side1">
						<ul>
							<hr id="hz"/>
							<li><a href="loginForm.aspx">asp.net Class w/ forum</a></li><hr id="hz"/>
							<li><a href="#">asp.net design w/ forum</a></li><hr id="hz"/>
							<li><a href="#">asp.net Toolbox w/ forum</a></li><hr id="hz"/>
							<li><a href="#">Databases w/ forum</a></li><hr id="hz"/>
							<li><a href="#">MSSQL tutorials w/ forum</a></li><hr id="hz"/>
							<li><a href="#">SQL Querries w/ forum</a></li><hr id="hz"/>
							<li><a href="#">SQL Injection w/ forum</a></li><hr id="hz"/>
							<li><a href="#">asp.net Function w/ forum</a></li><hr id="hz"/>
							<li><a href="#">WEB asp.net w/ forum</a></li><hr id="hz"/>
							<li><a href="#">Datatypes w/ forum</a></li><hr id="hz"/>
						</ul>
					</div>
					</li>
					
					
					<li>
					<h2>Related Topics</h2>
					<div id="side1">
						<ul>
							<hr id="hz"/>
							<li><a href="#">About css</a></li><hr id="hz"/>
							<li><a href="#">About javascript</a></li><hr id="hz"/>
							<li><a href="#">About HTML</a></li><hr id="hz"/>
							<li><a href="#">About PHP</a></li><hr id="hz"/>
							<li><a href="#">About c++</a></li><hr id="hz"/>
							<li><a href="#">About f#</a></li><hr id="hz"/>
							<li><a href="#">About C</a></li><hr id="hz"/>
							<li><a href="#">About Joomla</a></li><hr id="hz"/>
							<li><a href="#">About Drupal</a></li><hr id="hz"/>
							<li><a href="#">About WordPress</a></li><hr id="hz"/>
						</ul>
					</div>
					</li>
					
					
					<li>
					<h2>Recent Reports</h2>
					<div id="side1">
						<ul>
							<hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
							<li><a href="#">Jake Duldulao</a></li><hr id="hz"/>
						</ul>
					</div>
					</li>
					
					
					
				</ul>
			</div>
			
			
			
			
		<div id="content">
			<div class="post">
				<h1 class="title"><a href="#">Welcome to c# Tutorials Duldulao</a></h1>
				<div class="entry">
					<p>C# language is widely use today especially in some Big universities. It is just a programming language, that enables programmers to quickly build a wide range of applications for the new Microsoft .NET platform.We can say like English is a language, you can speak from your mouth.
In this example English = C# and Mouth= .NET platform. You need a language as a means of communication, in your case you may use C#.C# ASP.NET  Tutorials: Every professional and students are welcome in posting some important matters about learning the ASP.net c#.
</p>
				</div>
			</div>
			
			
			
			<div class="post">
				<h2 class="title"><a href="#">c# Tutorials Objectives</a></h2>
				<p class="byline"><small>Posted on August 1st, 2011 by <a href="#"> Duldulao Jake V </a></small></p>
				<div class="entry">
					<p>•	To emphasize the importance of learning C# asp.net.</p>
					<p>•	To clarify things specially when it comes to coding techniques.</p>
					<p>•	To develop our skills in programming techniques..</p>
					<p>•	Sharing of knowledge and ideas about specific topic.</p>
				</div>
			</div>
			
			
			<div class="post">
				<h2 class="title"><a href="#">Php Tutorialsssss</a></h2>
				
				
				
				<div>
				    <table>
				        <tr>
				            <td>LastName:</td><td><asp:TextBox ID="txtlastname" runat="server" Width="217px"></asp:TextBox></td>
				        </tr>
				        <tr>
				            <td>FirstName:</td><td><asp:TextBox ID="txtfirstname" runat="server" Width="217px"></asp:TextBox></td>
				        </tr>
				        <tr>
				            <td>MiddleName:</td><td><asp:TextBox ID="txtmiddlename" runat="server" Width="217px"></asp:TextBox></td>
				        </tr>
				        <tr>
				            <td>Picture:</td><td><div><asp:FileUpload runat="server" ID="flImage"/></div></td>
				        </tr>
				        <tr>
				            <td></td><td><asp:Button runat="server"  ValidationGroup="Details" 
                                ID="btnSubmit" Text="Upload & Save" onclick="btnSubmit_Click" Width="217px"/></td>
				        </tr>
				    </table>
				</div>
				
				<div><asp:Label ID="lblRes" runat="server" Text="Label"></asp:Label></div>
				<div></div>
                        
				
				<p class="byline"><small>Posted on October 1st, 2009 by <a href="#">Free CSS Templates</a></small></p>
				<div>
				
				
				     <asp:GridView ID="GridView1" CssClass ="Gridview" runat="server" 
    AutoGenerateColumns="False" HeaderStyle-BackColor="#7779AF" 
    HeaderStyle-ForeColor="White" BackColor="LightGoldenrodYellow" BorderColor="Tan" 
                         BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
    <Columns>
    <asp:BoundField HeaderText="LastName____________" DataField ="LastN" />
        <asp:BoundField DataField="FirstN" HeaderText="FirstName______________" />
    <asp:TemplateField HeaderText ="Image">
    <ItemTemplate>
    <asp:Image ID="Image1" runat ="server" ImageUrl='<%# "Handler.ashx?ImID="+ Eval("msgid") %>' Height="150px" Width= "150px" />   
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
                         
                         <FooterStyle BackColor="Tan" />
                         <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                             HorizontalAlign="Center" />
                         <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />

<HeaderStyle BackColor="Tan" Font-Bold="True"></HeaderStyle>
                         <AlternatingRowStyle BackColor="PaleGoldenrod" />
    </asp:GridView> 
				</div>
               <div>
                   <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
                       <Columns>
                           <asp:BoundField DataField="msgid" HeaderText="ID" />
                           <asp:ImageField DataImageUrlField="pic1" HeaderText="pic">
                           </asp:ImageField>
                       </Columns>
                   </asp:GridView>
               </div>
               
               <div>
                   <asp:GridView ID="GridView3" runat="server">
                   </asp:GridView>
                   
                   
                   
                   
               </div>
				<div class="entry">
					<p>Consectetuer adipiscing elit. Nam pede erat, porta eu, lobortis eget, tempus et, tellus. Etiam neque. Vivamus consequat lorem at nisl. Nullam non wisi a sem semper eleifend. Donec mattis libero eget urna. Duis pretium velit ac mauris. Proin eu wisi suscipit nulla suscipit interdum. Aenean lectus lorem, imperdiet at, ultrices eget, ornare et, wisi. </p>
					<p>Consectetuer adipiscing elit. Nam pede erat, porta eu, lobortis eget, tempus et, tellus. Etiam neque. Vivamus consequat lorem at nisl. Nullam non wisi a sem semper eleifend. Donec mattis libero eget urna. Duis pretium velit ac mauris. Proin eu wisi suscipit nulla suscipit interdum. Aenean lectus lorem, imperdiet at, ultrices eget, ornare et, wisi. </p>
				</div>
				
				<div>
				    <fieldset style="height: 363px; width: 462px">
				        <div>Email Sender>>>></div>
				        <table>
				            <tr>
                <td>Select MailName:</td><td><asp:DropDownList ID="DropDownList1" 
                    runat="server" Height="25px" Width="295px">
                                        <asp:ListItem Selected="True">Gmail Server</asp:ListItem>
                                        <asp:ListItem>Yahoo Mail Server</asp:ListItem>
                                        <asp:ListItem>Hot Mail Server</asp:ListItem>
                                        <asp:ListItem>Duldulao Mail Server</asp:ListItem>
                                        </asp:DropDownList></td>
            </tr>
            <tr>
                <td>Email Address(Sender):</td> <td><asp:TextBox ID="txtSender" runat="server" 
                    Width="290px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password:</td><td><asp:TextBox ID="txtPassword" TextMode="Password" 
                    runat="server" Width="290px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email Address(Receiver):</td><td><asp:TextBox ID="txtEmail" runat="server" 
                    Width="290px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Subject:</td><td><asp:TextBox ID="txtSubject" runat="server" Width="290px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Message:>></td><td><asp:TextBox ID="txtAreas" runat="server" Height="150px" TextMode="MultiLine" Width="290px"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td><td><asp:Button ID="btnSendEmail" runat="server" Text="Send" 
                    OnClick="btnSendEmail_Click" Width="297px"/></td>
            </tr>
            <tr>
                <td></td><td> <asp:Label ID="Label5" runat="server" ></asp:Label></td>
            </tr>
				        </table>
				    </fieldset>
				</div>
			</div>
			

		</div>
		
		
		
		
		<div id="sidebar2" class="sidebarb">
				<ul>
					
					<li>
					<h2>Month of Post</h2>
                        
					<table>
					    <tr>
					        <td><h3>Select Year</h3></td><td><asp:DropDownList ID="DropDownList2" runat="server" Height="21px" 
                                            Width="139px">
                                        <asp:ListItem>yr 2000</asp:ListItem>
                                        <asp:ListItem>yr 2001</asp:ListItem>
                                        <asp:ListItem>yr 2002</asp:ListItem>
                                        <asp:ListItem>yr 2003</asp:ListItem>
                                        <asp:ListItem>yr 2004</asp:ListItem>
                                        <asp:ListItem>yr 2005</asp:ListItem>
                                        <asp:ListItem>yr 2006</asp:ListItem>
                                        <asp:ListItem>yr 2007</asp:ListItem>
                                        <asp:ListItem>yr 2008</asp:ListItem>
                                        <asp:ListItem>yr 2009</asp:ListItem>
                                        <asp:ListItem>yr 2010</asp:ListItem>
                                        <asp:ListItem>yr 2011</asp:ListItem>
                                        <asp:ListItem>yr 2012</asp:ListItem>
                                        </asp:DropDownList></td>
					    </tr>
					</table>
					    <div id="Sides2">
						<ul>
							<li><a href="#">January</a></li>
							<li><a href="#">February</a></li>
							<li><a href="#">March</a></li>
							<li><a href="#">April</a></li>
							<li><a href="#">May</a></li>
							<li><a href="#">June</a></li>
							<li><a href="#">July</a></li>
							<li><a href="#">August</a></li>
							<li><a href="#">September</a></li>
							<li><a href="#">October</a></li>
						</ul>
						</div>
					</li>
					
					<li>
					<h2>Related forums</h2>
					    <div id="Sides2">
						<ul>
							<li><a href="#">About css forum</a></li><hr id="Hr2"/>
							<li><a href="#">About javascript forum</a></li><hr id="Hr3"/>
							<li><a href="#">About HTML forum</a></li><hr id="Hr4"/>
							<li><a href="#">About PHP forum</a></li><hr id="Hr5"/>
							<li><a href="#">About c++ forum</a></li><hr id="Hr6"/>
							<li><a href="#">About f# forum</a></li><hr id="Hr7"/>
							<li><a href="#">About C forum</a></li><hr id="Hr8"/>
							<li><a href="#">About Joomla forum</a></li><hr id="Hr9"/>
							<li><a href="#">About Drupal forum</a></li><hr id="Hr10"/>
							<li><a href="#">About WordPress forum</a></li><hr id="Hr11"/>
						</ul>
						</div>
					</li>
					
					<li>
					<h2>Recent Reports</h2>
					    <div id="Sides2">
						<ul>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
						</ul>
						</div>
					</li>
					
					<li>
					<h2>Recent Reports</h2>
					    <div id="Sides2">
						<ul>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
						</ul>
						</div>
					</li>
					
					<li>
					<h2>Recent Reports</h2>
					    <div id="Sides2">
						<ul>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
							<li><a href="#">Jake Duldulao</a></li>
						</ul>
						</div>
					</li>
					
				
					
					
					
				</ul>
			</div>
			<div style="clear: both;">&nbsp;</div>
		</div>
		</div>
		
		
		
		
	</div>
	
	<div id="footer">
        <div id="footer-bg">
	            <p class="copyright">&copy;&nbsp;&nbsp;2009 All Rights Reserved &nbsp;&bull;&nbsp; Design by <a href="#">Duldulao Jake V.</a>.</p>
	            <p class="link"><a href="#">Privacy Policy</a>&nbsp;&#8226;&nbsp;<a href="#">Terms of Use</a></p>
        </div>
    </div>
    <div style="text-align: center; font-size: 0.75em;">Design downloaded from <a href="http://www.freewebtemplates.com/">free website templates</a>.</div>
    </form>
</body>
</html>
