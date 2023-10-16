package com.example.myapplication

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.text.KeyboardOptions
import androidx.compose.material3.Button
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController
import com.example.myapplication.ui.theme.MyApplicationTheme

class Register : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            MyApplicationTheme {
                // A surface container using the 'background' color from the theme

            }
        }
    }
}
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun RegisterScreen(
    navController: NavController
){
    var _username by remember {
        mutableStateOf("")
    }
    var _password by remember {
        mutableStateOf("")
    }
    var _confirmpassword by remember {
        mutableStateOf("")
    }
    Column(
        modifier = Modifier
            .fillMaxSize()
            .background(color= Color.White),
        verticalArrangement = Arrangement.Center,
        horizontalAlignment = Alignment.CenterHorizontally
    ) {
        Text(text = "REGISTER", fontSize = 40.sp, fontWeight = FontWeight.ExtraBold)
        TextField(
            modifier = Modifier.padding(top = 15.dp),
            value = _username, onValueChange = {_username=it},
            label = { Text(text = "Account") },
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Text)
        )
        TextField(
            modifier = Modifier.padding(top = 15.dp),
            value = _password, onValueChange = {_password=it},
            label = { Text(text = "Password") },
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Password)
        )
        TextField(
            modifier = Modifier.padding(top = 15.dp),
            value = _confirmpassword, onValueChange = {_confirmpassword=it},
            label = { Text(text = "Confirm password") },
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Password)
        )
        Row (
            modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.SpaceEvenly,
            verticalAlignment = Alignment.CenterVertically
        ){
            Button(modifier = Modifier.padding(top=15.dp),onClick = {
                navController.navigate(Screen.Login.route)
            }) {
                Text(text = "LOGIN")
            }
            Button(modifier = Modifier.padding(top=15.dp),onClick = { }) {
                Text(text = "REGISTER")
            }
        }
    }
}