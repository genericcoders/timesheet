import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HighlightDirective } from './highlight.directive'
import { UserComponent } from './components/user/user.component';
import { TopnavComponent } from './components/topnav/topnav.component';

@NgModule({
  declarations: [
    AppComponent,
    HighlightDirective,
    UserComponent,
    TopnavComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
