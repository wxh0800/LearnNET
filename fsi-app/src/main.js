import Vue from 'vue'
import App from '@/App.vue'
import router from '@/router'
import store from '@/store/index'
import mixins from '@/util/mixins.js'
import * as filters from '@/util/filters.js'

// Import Bootstrap
import '@/assets/bootstrap.scss'

// Import Bootstrap-Vue
import BootstrapVue from 'bootstrap-vue'

// Import FontAwesome
import '@/assets/fontawesome.js'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'

// Import Axios
import axios from 'axios'

window.axios = axios
window.axios.defaults.headers.post['Content-Type'] = 'application/json;charset=utf-8'

// Configure Vue
Vue.config.productionTip = true

// Register BootstrapVue components
Vue.use(BootstrapVue)

// Register FontAwesome
Vue.component('fa', FontAwesomeIcon)

// Register mixins
Vue.mixin(mixins)

// Register filters
Object.keys(filters).forEach(key => {
	Vue.filter(key, filters[key])
})

new Vue({
	router,
	store,
	render: h => h(App)
}).$mount('#app')
