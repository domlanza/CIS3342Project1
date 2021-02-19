<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CIS3342_Solution.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Feedback Form</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous"/>
    <style>
        body {
            margin-left: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <h2> Your Results </h2>
       
        <div class="form-group col-md-4">
            <label for="formGroupExampleInput">First Name: </label>
            <input type="text" class="form-control" id="formGroupExampleInput" <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
         </div>
        <br />        

        <div class="form-group col-md-4">
            <label for="formGroupExampleInput">Last Name: </label>
            <input type="text" class="form-control" id="formGroupExampleInput1" <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
         </div>
        <br />    
        
        <div class="form-group col-md-4">
            <label for="formGroupExampleInput">Temple University Identification Number: </label>
            <input type="text" class="form-control" id="formGroupExampleInput2" <asp:TextBox ID="txtTUID" runat="server"></asp:TextBox>
         </div>
        <br />  
       
        <div class="form-group col-md-4">
            <label for="formGroupExampleInput">Class Selection: </label>
            <input type="text" class="form-control" id="formGroupExampleInput3" <asp:TextBox ID="txtClassName" runat="server"></asp:TextBox>
         </div>
        
        <br />  
                <label for="formGroupExampleInput">Question Answers:</label>
        <br />
        <asp:ListBox ID="QuestionReview" runat="server"></asp:ListBox>
        <br />
        <br />
         
        <div class="form-group col-md-4">
            <label for="formGroupExampleInput">Course Score:</label>
            <input type="text" class="form-control" id="formGroupExampleInput4" <asp:TextBox ID="txtCourseScore" runat="server"></asp:TextBox>
         </div>
        <br />  

         <div class="form-group col-md-4">
            <label for="formGroupExampleInput">Professor Score:</label>
            <input type="text" class="form-control" id="formGroupExampleInput5" <asp:TextBox ID="txtProfessorScore" runat="server"></asp:TextBox>
         </div>
        <br />  
       
        <div class="form-group col-md-4">
            <label for="formGroupExampleInput">Course Feedback Letter Grade: </label>
            <input type="text" class="form-control" id="formGroupExampleInput6" <asp:TextBox ID="txtCourseLetterGrade" runat="server"></asp:TextBox>
         </div>
        <br />  

        <div class="form-group col-md-4">
            <label for="formGroupExampleInput">Professor Feedback Letter Grade:</label>
            <input type="text" class="form-control" id="formGroupExampleInput7" <asp:TextBox ID="txtProfessorLetterGrade" runat="server"></asp:TextBox>
         </div>
        <br />  


    </form>
</body>
</html>
