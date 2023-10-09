package com.example.myapplication

import android.os.Bundle
import android.util.Size
import android.util.SizeF
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.text.KeyboardOptions
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Add
import androidx.compose.material.icons.filled.Close
import androidx.compose.material.icons.filled.Edit
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldColors
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.material3.TopAppBar
import androidx.compose.material3.TopAppBarDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import com.example.myapplication.ui.theme.MyApplicationTheme
import androidx.compose.runtime.setValue
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.em
import androidx.compose.ui.unit.sp

class MainActivity4 : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            MyApplicationTheme {
                // A surface container using the 'background' color from the theme
                Surface(
                    modifier = Modifier.fillMaxSize(),
                    color = MaterialTheme.colorScheme.background
                ) {
                    CalculatorScreen2()
                }
            }
        }
    }
}
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun CalculatorScreen2(modifier: Modifier=Modifier){
    var sothu1 by remember {
        mutableStateOf("")
    }
    var sothu2 by remember {
        mutableStateOf("")
    }
    var ketqua by remember {
        mutableStateOf("...")
    }
    Scaffold(modifier= modifier.padding(12.dp),
        topBar = {
            TopAppBar(colors = TopAppBarDefaults.smallTopAppBarColors(
                containerColor = Color.Blue,
                titleContentColor = Color.White,
            ),title ={ Text(text = "Máy tính")})
        }) {it ->
        Column (modifier= modifier
            .fillMaxWidth()
            .padding(it))
        {
            TextField(modifier= modifier
                .fillMaxWidth(),
                value = sothu1, 
                onValueChange = { sothu1=it},
                colors = TextFieldDefaults.textFieldColors(containerColor = Color.White),
                keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Number),
                placeholder = { Text(text = "Nhập số thứ nhất", color = Color.Gray)}
            )
            TextField(modifier= modifier
                .fillMaxWidth()
                .padding(bottom = 20.dp),
                value = sothu2,
                onValueChange = { sothu2=it},
                colors = TextFieldDefaults.textFieldColors(containerColor = Color.White),
                keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Number),
                placeholder = { Text(text = "Nhập số thứ hai", color = Color.Gray)}
            )
            Row(modifier = modifier.fillMaxWidth(), horizontalArrangement = Arrangement.SpaceBetween){
                IconButton(
                    onClick = {
                        try {
                            ketqua = ""
                            var so1 = sothu1.toInt()
                            var so2 = sothu2.toInt()
                            var kq=so1+so2
                            ketqua += "$so1 + $so2 = $kq"
                        } catch (e: Exception) {
                            ketqua = "Nhập dữ liệu sai"
                        }
                    },
                ) {
                    Icon(Icons.Filled.Add, " ", tint = Color.Blue)
                }
                Button(
                    onClick = {
                        try {
                            ketqua = ""
                            var so1 = sothu1.toInt()
                            var so2 = sothu2.toInt()
                            var kq=so1-so2
                            ketqua += "$so1 - $so2 = $kq"
                        } catch (e: Exception) {
                            ketqua = "Nhập dữ liệu sai"
                        }
                    },
                    colors = ButtonDefaults.buttonColors(containerColor = Color.White)
                ) {
                    Text(text = "-",color=Color.Blue, fontSize = 22.sp, textAlign = TextAlign.Start)
                }
                IconButton(
                    onClick = {
                        try {
                            ketqua = ""
                            var so1 = sothu1.toInt()
                            var so2 = sothu2.toInt()
                            var kq=so1*so2
                            ketqua += "$so1 * $so2 = $kq"
                        } catch (e: Exception) {
                            ketqua = "Nhập dữ liệu sai"
                        }
                    },
                ) {
                    Icon(Icons.Filled.Close, " ", tint = Color.Blue)
                }
                Button(
                    onClick = {
                        try {
                            ketqua = ""
                            var so1 = sothu1.toInt()
                            var so2 = sothu2.toInt()
                            var kq:Double
                            ketqua += if(so2!=0) {
                                kq=(so1/so2).toDouble()
                                "$so1 / $so2 = $kq"
                            }else{
                                "Không thể chia 0"
                            }
                        } catch (e: Exception) {
                            ketqua = "Nhập dữ liệu sai"
                        }
                    },
                    colors=ButtonDefaults.buttonColors(Color.White)
                ) {
                    Text(text = "/",color=Color.Blue, fontWeight = FontWeight.ExtraBold,
                        fontSize = 15.sp)
                }
            }
            Row(modifier = modifier
                .padding(bottom = 200.dp)
                .fillMaxWidth(), horizontalArrangement = Arrangement.Center){
                Text(text = "Kết quả: $ketqua")
            }
        }
        
    }
}
@Preview(showBackground = true)
@Composable
fun CalculatorPreview2() {
    CalculatorScreen2()
}