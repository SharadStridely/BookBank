import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CreateBookComponent } from './Book/create-book/create-book.component';
import { DeleteBookComponent } from './Book/delete-book/delete-book.component';
import { UpdateBookComponent } from './Book/update-book/update-book.component';
import { GetallBookComponent } from './Book/getall-book/getall-book.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CreateBookComponent,
    DeleteBookComponent,
    UpdateBookComponent,
    GetallBookComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
